using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using EntityLayer;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;

namespace SubastAPP
{
    public partial class frm_Login : Form
    {
        //private readonly MaterialSkinManager materialSkinManager;
        private readonly MaterialSkinManager materialSkinManager;
        private ClienteConexion _conexionCliente;


        public frm_Login()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange700, Primary.Orange900, Primary.Red500, Accent.LightBlue700, TextShade.WHITE);
            
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string email = txt_LoginEmail.Text;
            string password = txt_LoginPassword.Text;

            // Crear el mensaje JSON para login
            var loginData = new
            {
                tipoMensaje = "login",
                email = email,
                password = password
            };

            string jsonMessage = JsonConvert.SerializeObject(loginData);

            // Iniciar la sesión y conectar al servidor
            if (ClienteSession.IniciarSesion("127.0.0.1", 12345))
            {
                // Enviar el mensaje de login al servidor y obtener la respuesta
                string response = ClienteSession.ConexionCliente.EnviarMensaje(jsonMessage);

                // Si el login es exitoso, mostrar la siguiente ventana
                if (response == "true")
                {
                    frm_MainSubastApp _objFrmMainSubastApp = new frm_MainSubastApp();
                    _objFrmMainSubastApp.ShowDialog();
                }
                else
                {
                    // Mostrar la respuesta del servidor si el login no fue exitoso
                    MessageBox.Show(response);
                }
            }
            // Mostrar la respuesta del servidor
            //MessageBox.Show(response);
        }

        //private string SendLoginRequest(string jsonMessage)
        //{
        //    try
        //    {
        //        using (TcpClient client = new TcpClient("127.0.0.1", 12345)) 
        //        {
        //            NetworkStream stream = client.GetStream();
        //            byte[] data = Encoding.UTF8.GetBytes(jsonMessage);

        //            // Enviar el mensaje al servidor
        //            stream.Write(data, 0, data.Length);

        //            // Leer la respuesta del servidor
        //            byte[] buffer = new byte[1024];
        //            int bytesRead = stream.Read(buffer, 0, buffer.Length);
        //            return Encoding.UTF8.GetString(buffer, 0, bytesRead);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return "Error de conexión: " + ex.Message;
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Login_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 0;
            lbl_TituloVentana.Text = "LOGIN";
        }

        private void lbl_SignUp_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 1;
            lbl_TituloVentana.Text = "SIGN UP";
        }

        private void ChangeOverForeColorButton(Object sender, EventArgs e)
        {

            Button boton = (Button)sender;

            boton.ForeColor = Color.White;
        }

        private void ChangeLeaveForeColorButton(Object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            boton.ForeColor = Color.Silver;
        }

        private void btn_SignUpRegister_Click(object sender, EventArgs e)
        {
            string nombre = txt_SignUpFullName.Text;
            string email = txt_SignUpEmail.Text;
            string telefono = txt_SignUpPhoneNumber.Text;
            string password = txt_SignUpPassword.Text;
            string confirmacionPassword = txt_SignUpConfirmPassword.Text;

            // Validaciones
            if (password != confirmacionPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            // Crear el objeto que contiene los datos a enviar
            var datosUsuario = new
            {
                tipoMensaje = "register",  // Tipo de mensaje
                nombre = nombre,
                email = email,
                telefono = telefono,
                password = password
            };

            // Convertir el objeto a JSON
            string json = JsonConvert.SerializeObject(datosUsuario);

            // Enviar los datos al servidor
            EnviarDatosAlServidor(json);

        }

        private void EnviarDatosAlServidor(string mensajeJson)
        {
            try
            {
                using (TcpClient cliente = new TcpClient("127.0.0.1", 12345))  // Conectar al servidor
                {
                    NetworkStream stream = cliente.GetStream();

                    // Convertir el mensaje JSON a bytes y enviarlo al servidor
                    byte[] datos = Encoding.UTF8.GetBytes(mensajeJson);
                    stream.Write(datos, 0, datos.Length);

                    // Leer la respuesta del servidor
                    byte[] buffer = new byte[256];
                    int bytesLeidos = stream.Read(buffer, 0, buffer.Length);
                    string respuesta = Encoding.UTF8.GetString(buffer, 0, bytesLeidos);

                    // Mostrar la respuesta
                    MessageBox.Show(respuesta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_conexionCliente != null)
            {
                _conexionCliente.CerrarConexion();
                MessageBox.Show("Desconectado del servidor.");
            }
        }
    }
}

