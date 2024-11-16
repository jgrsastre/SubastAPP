using Newtonsoft.Json;
using ServerLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ServerLayer
{
    class ClienteHandler
    {
        private static Conexion objCon = new Conexion();

        private readonly TcpClient _client;

        private string _clienteId;  // Aquí vamos a almacenar la identificación del cliente una vez se loguee

        // Diccionario para mantener las sesiones activas
        private Dictionary<string, string> clientesLogueados = new Dictionary<string, string>();


        public ClienteHandler(TcpClient client)
        {
            _client = client;
        }

        public void HandleClient()
        {
            try
            {
                NetworkStream stream = _client.GetStream();
                byte[] buffer = new byte[_client.ReceiveBufferSize];

                // Leer los datos enviados por el cliente
                int bytesLeidos = stream.Read(buffer, 0, buffer.Length);
                string mensaje = Encoding.UTF8.GetString(buffer, 0, bytesLeidos);

                // Deserializar el mensaje JSON
                var datos = JsonConvert.DeserializeObject<dynamic>(mensaje);

                Console.WriteLine("TOKEN: "+ Program.IsClienteLogueado(_client));
                // Verificar el tipo de mensaje (por ejemplo, login o registro)
                if (datos.tipoMensaje == "login")
                {
                    Console.WriteLine("LOGIN: " + Program.IsClienteLogueado(_client));

                    string email = datos.email;
                    string password = datos.password;

                    // Verificar las credenciales
                    if (VerificarCredenciales(email, password))
                    {
                        // Crear una nueva sesión para el cliente
                        var session = new Session
                        {
                            ClienteId = email,
                            LoginTime = DateTime.Now,
                            IsLoggedIn = true
                        };

                        // Almacenar la sesión en el diccionario global
                        Program.AddClienteLogueado(_client, session);

                        string responseMessage = "true";
                        SendResponse(stream, responseMessage);
                    }
                    else
                    {
                        // Si las credenciales son incorrectas
                        string responseMessage = "Credenciales incorrectas.";
                        SendResponse(stream, responseMessage);
                    }
                }
                else if (Program.IsClienteLogueado(_client))  // Si el cliente ya está logueado, procesamos otras solicitudes
                {
                    Console.WriteLine("LOGUEADO: " + Program.IsClienteLogueado(_client));

                    if (datos.tipoMensaje == "RegisterAuction")
                    {
                        // Obtener los datos de la subasta
                        var subasta = datos.Data;

                        // Eliminar el prefijo "data:image/png;base64," o "data:image/jpeg;base64,"
                        string base64String = subasta.ImagenBase64;

                        // Limpiar cualquier posible encabezado de la cadena base64
                        if (base64String.StartsWith("data:image/png;base64,"))
                        {
                            base64String = base64String.Substring("data:image/png;base64,".Length);
                        }
                        else if (base64String.StartsWith("data:image/jpeg;base64,"))
                        {
                            base64String = base64String.Substring("data:image/jpeg;base64,".Length);
                        }
                        else if (base64String.StartsWith("data:image/jpg;base64,"))
                        {
                            base64String = base64String.Substring("data:image/jpg;base64,".Length);
                        }

                        byte[] imagenBytes = Convert.FromBase64String(base64String);


                        // Guardar la imagen en el servidor
                        string imagenNombre = Guid.NewGuid().ToString() + ".jpg";  // Crear un nombre único para la imagen
                        string imagenRuta = Path.Combine(@"C:\ImagenesSubastas", imagenNombre);

                        File.WriteAllBytes(imagenRuta, imagenBytes);  // Guardar la imagen en el servidor

                        string titulo = subasta.titulo;
                        string descripcion = subasta.descripcion;
                        DateTime fechaInicio = subasta.fecha_inicio;
                        DateTime fechaFin = subasta.fecha_fin;
                        decimal precioInicial = subasta.precio_inicial;
                        string nombreCategoria = subasta.nombre_categoria;
                        decimal precioVenta = subasta.precio_venta;
                        string IimagenRuta = imagenRuta;

                        RegistrarSubasta(titulo, descripcion, fechaInicio,
                            fechaFin, precioInicial, nombreCategoria, precioVenta, IimagenRuta);

                        // Responder al cliente
                        byte[] respuesta = Encoding.UTF8.GetBytes("Subasta registrada exitosamente.");
                        stream.Write(respuesta, 0, respuesta.Length);


                        Console.WriteLine("Subasta registrada con éxito.");
                    }
                    else if (datos.tipoMensaje == "GetAuctions")
                    {
                        Console.WriteLine("Obteniendo Subastaws");
                        // Obtener las subastas de la base de datos
                        List<E_AuctionServer> subastas = ObtenerSubastasDesdeBD();

                        // Crear la respuesta
                        E_MessageContentServer respuesta = new E_MessageContentServer();
                        respuesta.Type = "AuctionsList";  // Tipo de la respuesta
                        respuesta.Data = subastas;  // Datos de las subastas

                        // Serializar la respuesta a JSON
                        string respuestaJson = JsonConvert.SerializeObject(respuesta);

                        // Convertir la respuesta en bytes
                        byte[] respuestaBytes = Encoding.UTF8.GetBytes(respuestaJson);

                        // Enviar la respuesta al cliente
                        stream.Write(respuestaBytes, 0, respuestaBytes.Length);
                    }
                    else
                    {
                        // Si el tipo de mensaje no es reconocido
                        byte[] respuesta = Encoding.UTF8.GetBytes("Tipo de mensaje no reconocido.");
                        stream.Write(respuesta, 0, respuesta.Length);
                    }
                }
                else if (datos.tipoMensaje == "register")
                {
                    string nombre = datos.nombre;
                    string email = datos.email;
                    string password = datos.password;
                    DateTime fecha_registro = DateTime.Now;
                    string rol_id = "2";
                    string telefono = datos.telefono;

                    // Registrar al usuario en la base de datos
                    Console.WriteLine(fecha_registro);
                    if (RegistrarUsuario(nombre, email, password, fecha_registro, rol_id, telefono))
                    {
                        // Responder al cliente
                        byte[] respuesta = Encoding.UTF8.GetBytes("Usuario registrado exitosamente.");
                        stream.Write(respuesta, 0, respuesta.Length);
                    }
                    else
                    {
                        // Responder al cliente
                        byte[] respuesta = Encoding.UTF8.GetBytes("Ya existe un usuario registrado con el correo.");
                        stream.Write(respuesta, 0, respuesta.Length);
                    }


                }
                else
                {
                    // Si el cliente no está logueado, no puede realizar ninguna otra acción
                    SendResponse(stream, "Debe iniciar sesión primero.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al manejar el cliente: " + ex.Message);
            }
            finally
            {
                // Eliminar la sesión del cliente cuando se desconecta
                //Program.RemoveClienteLogueado(_client);
                //Console.WriteLine("Cliente desconectado");
                //_client.Close();
            }
        }

        // Método para verificar las credenciales del cliente
        private bool VerificarCredenciales(string email, string password)
        {
            try
            {
                // Aquí se conecta a la base de datos para verificar las credenciales del cliente
                using (SqlConnection conn = objCon.getConecta())
                {
                    string query = "SELECT contrasena FROM Usuarios WHERE email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        conn.Open();
                        string hashedPassword = cmd.ExecuteScalar() as string;

                        if (!string.IsNullOrEmpty(hashedPassword) && BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                        {
                            return true; // Si las contraseñas coinciden
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar credenciales: " + ex.Message);
            }

            return false; // Si las credenciales no son correctas
        }

        // Método para enviar una respuesta al cliente
        private void SendResponse(NetworkStream stream, string message)
        {
            byte[] responseBytes = Encoding.UTF8.GetBytes(message);
            stream.Write(responseBytes, 0, responseBytes.Length);
        }

        // Método para obtener las subastas desde la base de datos
        public List<E_AuctionServer> ObtenerSubastasDesdeBD()
        {
            string query = "SELECT subasta_id, usuario_id, titulo, descripcion, fecha_inicio, fecha_fin, precio_inicial, nombre_categoria, precio_venta, ImagenRuta FROM Subastas";

            List<E_AuctionServer> subastas = new List<E_AuctionServer>();

            try
            {
                using (SqlConnection conn = objCon.getConecta())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Leer la imagen como bytes
                            byte[] imagenBytes = ReducirCalidadImagen(reader.GetString(9));

                            string imagenBase64 = Convert.ToBase64String(imagenBytes);

                            E_AuctionServer subasta = new E_AuctionServer
                            {
                                subasta_id = reader.GetInt32(0),
                                usuario_id = reader.GetInt32(1),
                                titulo = reader.GetString(2),
                                descripcion = reader.GetString(3),
                                fecha_inicio = reader.GetDateTime(4),
                                fecha_fin = reader.GetDateTime(5),
                                precio_inicial = reader.GetDecimal(6),
                                nombre_categoria = reader.GetString(7),
                                precio_venta = (decimal)(reader.IsDBNull(8) ? (decimal?)null : reader.GetDecimal(8)),
                                ImagenBase64 = imagenBase64  // Ruta de la imagen
                            };

                            subastas.Add(subasta);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener las subastas: {ex.Message}");
            }

            return subastas;
        }

        private byte[] ReducirCalidadImagen(string ruta_img)
        {
            using (var img = System.Drawing.Image.FromFile(ruta_img))
            {
                var resizedImage = img.GetThumbnailImage(300, 300, null, IntPtr.Zero);

                // Obtener el codec de la imagen JPEG
                var codec = ImageCodecInfo.GetImageDecoders().FirstOrDefault(c => c.FormatID == ImageFormat.Jpeg.Guid);

                // Establecer los parámetros de compresión
                var encoderParams = new EncoderParameters(1);
                encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 50L);  // Control de calidad

                // Guardar la imagen redimensionada y comprimida en un MemoryStream
                using (var memoryStream = new MemoryStream())
                {
                    resizedImage.Save(memoryStream, codec, encoderParams);
                    return memoryStream.ToArray();  // Devuelve los bytes de la imagen comprimida
                }
            }
        }


        private static void RegistrarSubasta(string titulo, string descripcion,
            DateTime fechaInicio, DateTime fechaFin, decimal precioInicial,
            string nombreCategoria, decimal precioVenta, string IimagenRuta)
        {
            try
            {
                using (SqlConnection conn = objCon.getConecta())
                {
                    string query = "INSERT INTO Subastas (usuario_id, titulo, descripcion, fecha_inicio," +
                        " fecha_fin, precio_inicial,nombre_categoria,precio_venta,ImagenRuta)" +
                        "VALUES (@usuario_id, @titulo, @descripcion, @fecha_inicio, @fecha_fin, @precio_inicial," +
                        "@nombre_categoria,@precio_venta,@ImagenRuta)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Hashear la contraseña
                        //string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

                        // Usar parámetros para evitar inyecciones SQL
                        cmd.Parameters.AddWithValue("@usuario_id", 3);
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@fecha_inicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@fecha_fin", fechaFin);
                        cmd.Parameters.AddWithValue("@precio_inicial", precioInicial);
                        cmd.Parameters.AddWithValue("@nombre_categoria", nombreCategoria);
                        cmd.Parameters.AddWithValue("@precio_venta", precioVenta);
                        cmd.Parameters.AddWithValue("@ImagenRuta", IimagenRuta);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar la subasta: " + ex.Message);
            }
        }


        private static bool RegistrarUsuario(string nombre, string email, string password, DateTime fecha_registro, string rol_id, string telefono)
        {
            try
            {

                // Verificar si el correo ya está registrado
                if (VerificarEmailExistente(email))
                {
                    //Console.WriteLine("El correo electrónico ya está registrado.");
                    return false;  // Salir del método si el email ya existe
                }
                using (SqlConnection conn = objCon.getConecta())
                {
                    string query = "INSERT INTO Usuarios (nombre, email, contrasena, fecha_registro, rol_id, phone_number) " +
                        "VALUES (@Nombre, @Email, @PasswordHash, @FechaRegistro, @RolID, @PhoneNumber)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Hashear la contraseña
                        string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

                        // Usar parámetros para evitar inyecciones SQL
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                        cmd.Parameters.AddWithValue("@FechaRegistro", fecha_registro.Date);
                        cmd.Parameters.AddWithValue("@RolID", rol_id);
                        cmd.Parameters.AddWithValue("@PhoneNumber", telefono);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery(); // Ejecutar la consulta

                        // Si rowsAffected es mayor que 0, significa que el registro fue exitoso
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar al usuario: " + ex.Message);
                return false;
            }
        }

        private static bool VerificarEmailExistente(string email)
        {
            string query = "SELECT COUNT(*) FROM Usuarios WHERE email = @Email";

            using (SqlConnection conn = objCon.getConecta())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;  // Retorna true si el email ya existe
                }
            }
        }
    }
}
