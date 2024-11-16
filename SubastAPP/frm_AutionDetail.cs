using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubastAPP
{
    public partial class frm_AutionDetail : Form
    {

        public frm_AutionDetail(E_Auction objEAuction)
        {
            InitializeComponent();

            pictureBox1.Image=objEAuction.ImagenSubasta;
            lbl_TitleAuction.Text = objEAuction.titulo;
            lbl_Category.Text = objEAuction.nombre_categoria;
            lbl_StartingDateAuction.Text = objEAuction.fecha_inicio.ToString("dd-MM-yyyy");
            lbl_EndDateAuction.Text = objEAuction.fecha_fin.ToString("dd-MM-yyyy");
            lbl_StartingPriceAuction.Text = objEAuction.precio_inicial.ToString();
            lbl_PurchasePrice.Text = objEAuction.precio_venta.ToString();
            lbl_BestOffer.Text = objEAuction.BestOffer.ToString();
            txt_Description.Text = objEAuction.descripcion;
        }

        // Método para convertir Base64 a imagen
        private Image ConvertirBase64AImagen(string base64)
        {
            byte[] imageBytes = Convert.FromBase64String(base64);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
