using BusinessLayer;
using EntityLayer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubastAPP
{
    public partial class frm_AuctionsList : Form
    {
        ////Para suavizar interfaz de la ventana
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public frm_AuctionsList()
        {
            InitializeComponent();

            //ObtenerSubastas();
        }

        // Método para enviar solicitud al servidor para obtener subastas
        private void ObtenerSubastas()
        {
            MessageBox.Show("SolicitandoSubastas");
            //try
            //{
                // Dirección y puerto del servidor
                //string servidorIP = "127.0.0.1";
                //int puerto = 12345;

                // Crear la solicitud de mensaje
                E_MessageContent solicitud = new E_MessageContent();
                solicitud.tipoMensaje = "GetAuctions";  // Tipo de la solicitud (indicamos que es para obtener subastas)
                solicitud.Data = null;  // En este caso no es necesario enviar datos adicionales

                // Serializar la solicitud a JSON
                string solicitudJson = JsonConvert.SerializeObject(solicitud);

            string response = ClienteSession.ConexionCliente.EnviarMensaje(solicitudJson);


            // Conectar con el servidor
            //using (TcpClient cliente = new TcpClient(servidorIP, puerto))
            //using (NetworkStream stream = cliente.GetStream())
            //{
            // Convertir el mensaje a bytes
            //byte[] solicitudBytes = Encoding.UTF8.GetBytes(solicitudJson);

            //        // Enviar la solicitud
            //        stream.Write(solicitudBytes, 0, solicitudBytes.Length);

            //        // Recibir la respuesta del servidor
            //        byte[] buffer = new byte[cliente.ReceiveBufferSize];
            //        int bytesLeidos = stream.Read(buffer, 0, buffer.Length);
            //        string respuestaJson = Encoding.UTF8.GetString(buffer, 0, bytesLeidos);

                    // Deserializar la respuesta
                    var respuesta = JsonConvert.DeserializeObject<E_MessageContent>(response);

                    if (respuesta.tipoMensaje == "AuctionsList")
                    {
                MessageBox.Show("SI ENTRO");
                        // Deserializar los datos de las subastas
                        List<E_Auction> subastas = JsonConvert.DeserializeObject<List<E_Auction>>(respuesta.Data.ToString());
                        dataGridView1.RowTemplate.Height = 150; // Puedes cambiar a 150 píxeles o el valor que desees

                        // Asignar los datos al DataGridView
                        foreach (var subasta in subastas)
                        {
                            // Crear una fila para cada subasta
                            int rowIndex = dataGridView1.Rows.Add();

                            // Asignar el nombre de la subasta
                            dataGridView1.Rows[rowIndex].Cells["c_Title"].Value = subasta.titulo;
                            dataGridView1.Rows[rowIndex].Cells["c_Description"].Value = subasta.descripcion;
                            dataGridView1.Rows[rowIndex].Cells["c_StartingPrice"].Value = subasta.precio_inicial;
                            dataGridView1.Rows[rowIndex].Cells["c_StartDate"].Value = subasta.fecha_inicio.ToString("dd-MM-yyyy");
                            dataGridView1.Rows[rowIndex].Cells["c_EndDate"].Value = subasta.fecha_fin.ToString("dd-MM-yyyy"); ;
                            dataGridView1.Rows[rowIndex].Cells["c_Category"].Value = subasta.nombre_categoria;
                            dataGridView1.Rows[rowIndex].Cells["c_PurchasePrice"].Value = subasta.precio_venta;
                            // Convertir la imagen Base64 a una imagen y asignarla a la celda de imagen
                            dataGridView1.Rows[rowIndex].Cells["c_Image"].Value = ConvertirBase64AImagen(subasta.ImagenBase64);
                        }
                    }
                //}
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error al obtener las subastas: {ex.Message}");
            //}
        }
        // Método para convertir una cadena Base64 a una imagen
        private Image ConvertirBase64AImagen(string base64String)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(base64String);
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception)
            {
                return null; // Si hay algún error al convertir la cadena Base64, devolver null
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos si el clic fue en la columna de botones (índice de la columna "c_BtnDetail")
            if (e.ColumnIndex == dataGridView1.Columns["c_BtnDetail"].Index)
            {
                // Obtener la fila seleccionada
                int rowIndex = e.RowIndex;

                // si la fila no esta vacía
                if (rowIndex >= 0)
                {
                    E_Auction subasta = new E_Auction();

                    subasta.ImagenSubasta = (Image)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 8].Value;
                    subasta.titulo = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 7].Value.ToString();
                    subasta.descripcion = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 6].Value.ToString();
                    subasta.precio_inicial = (decimal)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 5].Value;
                    subasta.fecha_inicio = DateTime.TryParseExact((string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 4].Value,
                                               "dd-MM-yyyy",
                                               CultureInfo.InvariantCulture,
                                               DateTimeStyles.None,
                                               out DateTime fechaInicio)
                        ? fechaInicio
                        : DateTime.MinValue; // Si no se puede convertir, asignamos DateTime.MinValue
                    subasta.fecha_fin = DateTime.TryParseExact((string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 3].Value,
                                           "dd-MM-yyyy",
                                           CultureInfo.InvariantCulture,
                                           DateTimeStyles.None,
                                           out DateTime fechaFin)
                    ? fechaFin
                    : DateTime.MinValue; // Si no se puede convertir, asignamos DateTime.MinValue
                    subasta.nombre_categoria = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value.ToString();
                   
                    ShowAuctionDetail(subasta);
                }
            }
        }

        private void ShowAuctionDetail(E_Auction subasta)
        {
            // Crear una nueva instancia del formulario con los datos de la subasta
            frm_AutionDetail _frmAuctionDetail = new frm_AutionDetail(subasta);
            // Mostrar el formulario
            _frmAuctionDetail.ShowDialog();
        }

        private void btn_LoadAuctions_Click(object sender, EventArgs e)
        {
            ObtenerSubastas();
        }
    }
}
