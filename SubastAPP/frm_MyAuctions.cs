using EntityLayer;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubastAPP
{
    public partial class frm_MyAuctions : Form
    {
        E_Auction _objEAuction;

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


        public frm_MyAuctions()
        {
            InitializeComponent();
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateSect = dtime_StartingDateAuction.Value;
            lbl_PreviewStartingDateAuction.Text = dateSect.ToShortDateString();

            DateTime nuevaFecha = dateSect.AddDays(+3);
            lbl_EndDateAuction.Text = nuevaFecha.ToShortDateString();
            lbl_PreviewEndDateAuction.Text = nuevaFecha.ToShortDateString();

        }

        private void txt_TitleAuction_TextChanged(object sender, EventArgs e)
        {
            lbl_PreviewTitleAuction.Text = txt_TitleAuction.Text.ToUpper();
        }


        private void txt_TitleAuction_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Limitar la cantidad de caracteres
            if (txt_TitleAuction.Text.Length >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar si se supera el límite
            }
        }

        private void txt_DescriptionAuction_TextChanged(object sender, EventArgs e)
        {
            txt_PreviewDescription.Text = txt_DescriptionAuction.Text;
        }

        private void cmbox_StartingPriceAuction_TextChanged(object sender, EventArgs e)
        {
            txt_StartingPriceAuction.Text = "";
            lbl_PreviewStartingPriceAuction.Text = cmbox_StartingPriceAuction.Text;
        }

        private void txt_StartingPriceAuction_TextChanged(object sender, EventArgs e)
        {
            lbl_PreviewStartingPriceAuction.Text = txt_StartingPriceAuction.Text;
        }

        private void txt_StartingPriceAuction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada
            }
        }

        private void txt_DirectPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            lbl_PreviewPurchasePrice.Text = txt_DirectPurchasePrice.Text;
        }

        private byte[] ReducirCalidadImagen(string ruta_img)
        {
            using (var img = Image.FromFile(ruta_img))
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

        private void btn_RegisterAuction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaImagen))
            {
                MessageBox.Show("Debe seleccionar una imagen.");
                return;
            }

            try
            {
                // Leer la imagen como bytes
                byte[] imagenBytes = ReducirCalidadImagen(rutaImagen); // 80 es el nivel de calidad

                string imagenBase64 = Convert.ToBase64String(imagenBytes);


                _objEAuction = new E_Auction();

                _objEAuction.titulo = lbl_PreviewTitleAuction.Text;
                _objEAuction.descripcion = txt_PreviewDescription.Text;
                _objEAuction.fecha_inicio = DateTime.ParseExact(lbl_PreviewStartingDateAuction.Text, "dd-MM-yy", System.Globalization.CultureInfo.InvariantCulture);
                _objEAuction.fecha_fin = DateTime.ParseExact(lbl_PreviewEndDateAuction.Text, "dd-MM-yy", System.Globalization.CultureInfo.InvariantCulture);
                _objEAuction.precio_inicial = decimal.Parse(lbl_PreviewStartingPriceAuction.Text, System.Globalization.CultureInfo.InvariantCulture);
                _objEAuction.nombre_categoria = lbl_Category.Text;
                _objEAuction.precio_venta = decimal.Parse(lbl_PreviewPurchasePrice.Text, System.Globalization.CultureInfo.InvariantCulture);

                // Asignar los bytes de la imagen
                _objEAuction.ImagenBase64 = imagenBase64;  // Usar ImagenBytes
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            E_MessageContent _objEMessageContent = new E_MessageContent();

            _objEMessageContent.tipoMensaje = "RegisterAuction";
            _objEMessageContent.Data = _objEAuction;

            // Serializar el mensaje a JSON
            string mensajeJson = JsonConvert.SerializeObject(_objEMessageContent);


            // Enviar el mensaje JSON al servidor
            EnviarSubastaAlServidor(mensajeJson);
        }

        private void EnviarSubastaAlServidor(string mensajeJson)
        {
            try
            {
                // Dirección y puerto del servidor
                string servidorIP = "127.0.0.1";
                int puerto = 12345;

                // Conexión con el servidor
                TcpClient cliente = new TcpClient(servidorIP, puerto);
                NetworkStream stream = cliente.GetStream();

                // Convertir el mensaje JSON a bytes
                byte[] mensajeBytes = Encoding.UTF8.GetBytes(mensajeJson);

                //// Enviar primero el tamaño del mensaje
                //byte[] tamañoMensaje = BitConverter.GetBytes(mensajeBytes.Length);
                //stream.Write(tamañoMensaje, 0, tamañoMensaje.Length);

                // Enviar el mensaje completo
                stream.Write(mensajeBytes, 0, mensajeBytes.Length);

                // Cerrar la conexión
                stream.Close();
                cliente.Close();

                MessageBox.Show("Subasta registrada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la subasta: {ex.Message}");
            }
        }

        private void cmbox_CategoryAuction_TextChanged(object sender, EventArgs e)
        {
            lbl_Category.Text = cmbox_CategoryAuction.Text;
        }

        string rutaImagen;

        private void btn_ImageProduct_Click(object sender, EventArgs e)
        {
            // Abre un cuadro de diálogo para seleccionar la imagen
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Mostrar la ruta seleccionada en un control (opcional)
                rutaImagen = openFileDialog.FileName;
                lbl_ConfirmImage.Text = "✔";
                picbox_PreviewImageAuction.ImageLocation = rutaImagen;
            }
        }
    }
}
