using BusinessLayer;
using EntityLayer;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubastAPP
{
    public partial class frm_MainSubastApp : Form
    {
        //List<Form> frm_ActiveTabList= new List<Form>();
        Form obj_FrmUserProfile;
        Form obj_FrmAutionList;
        Form obj_FrmMyOffers;
        Form obj_FrmMyAuctions;

        private B_SocketClient _socketClient;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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


        private readonly MaterialSkinManager materialSkinManager;

        public frm_MainSubastApp()
        {
            InitializeComponent();
            //materialTabControl1.TabPages.Remove(tbPage_MyAuctions);

            _socketClient = new B_SocketClient();


            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange700, Primary.Orange900, Primary.Red500, Accent.LightBlue700, TextShade.WHITE);

            //ConectServer();

        }

        //Este metodo es para hacer una posible validación con nrol.io
        private void ConectServer()
        {
            try
            {
                // Reemplaza con la dirección de tu servidor (puede ser localhost o la dirección proporcionada por Ngrok)
                string serverAddress = "localhost"; // o "<subdominio>.ngrok.io" para Ngrok por 
                int port = 12345;

                _socketClient.Connect(serverAddress, port);
                MessageBox.Show("Conectado al servidor.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar: {ex.Message}");
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabPageActive();
        }

        public void tabPageActive()
        {
            // Obtiene la TabPage activa
            TabPage activeTab = materialTabControl1.SelectedTab;
            int activeIndex = materialTabControl1.SelectedIndex;

            // Muestra el nombre de la TabPage activa
            lbl_TituloVentana.Text = "SubastAPP\\" + activeTab.Text;


            if (activeIndex == 0)
            {
                // Inicializa solo si es nulo
                if (obj_FrmUserProfile != null)
                {
                    //MessageBox.Show("Ya existe ese forms" + activeTab.Controls.Count.ToString());
                    return;
                }
                obj_FrmUserProfile = new frm_UserProfile();
                obj_FrmUserProfile.TopLevel = false;
                obj_FrmUserProfile.Dock = DockStyle.Fill;
                //obj_FrmAutionList.WindowState = FormWindowState.Maximized;
                tbPage_Profile.Controls.Add(obj_FrmUserProfile);
                //tb_Auctions.Tag = obj_FrmAutionList;
                //obj_FrmAutionList.TopMost = true;
                obj_FrmUserProfile.Show();
            }

            if (activeIndex == 1)
            {
                // Inicializa solo si es nulo
                if (obj_FrmAutionList != null)
                {
                    //MessageBox.Show("Ya existe ese forms" + activeTab.Controls.Count.ToString());
                    return;
                }
                obj_FrmAutionList = new frm_AuctionsList();
                obj_FrmAutionList.TopLevel = false;
                obj_FrmAutionList.Dock = DockStyle.Fill;
                //obj_FrmAutionList.WindowState = FormWindowState.Maximized;
                tb_Auctions.Controls.Add(obj_FrmAutionList);
                //tb_Auctions.Tag = obj_FrmAutionList;
                //obj_FrmAutionList.TopMost = true;
                obj_FrmAutionList.Show();
            }

            if (activeIndex == 2)
            {
                // Inicializa solo si es nulo
                if (obj_FrmMyOffers != null)
                {
                    //MessageBox.Show("Ya existe ese forms" + activeTab.Controls.Count.ToString());
                    return;
                }
                obj_FrmMyOffers = new frm_MyOffers();
                obj_FrmMyOffers.TopLevel = false;
                obj_FrmMyOffers.Dock = DockStyle.Fill;
                //obj_FrmMyOffers.WindowState = FormWindowState.Maximized;
                tb_MyOffers.Controls.Add(obj_FrmMyOffers);
                obj_FrmMyOffers.Show();
            }

            if (activeIndex == 3)
            {
                // Inicializa solo si es nulo
                if (obj_FrmMyAuctions != null)
                {
                    //MessageBox.Show("Ya existe ese forms" + activeTab.Controls.Count.ToString());
                    return;
                }
                obj_FrmMyAuctions = new frm_MyAuctions();
                obj_FrmMyAuctions.TopLevel = false;
                obj_FrmMyAuctions.Dock = DockStyle.Fill;

                //obj_FrmMyAuctions.WindowState = FormWindowState.Maximized;
                tbPage_MyAuctions.Controls.Add(obj_FrmMyAuctions);
                obj_FrmMyAuctions.Show();
            }
        }

        private void moveForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_ResizedForm_Click(object sender, EventArgs e)
        {
            if(this.WindowState!= FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!materialTabControl1.TabPages.Contains(tbPage_MyAuctions))
            {
                materialTabControl1.TabPages.Add(tbPage_MyAuctions);
            }

            MessageBox.Show("Agregado");
        }

        private void frm_MainSubastApp_Load(object sender, EventArgs e)
        {
            tabPageActive();

            if (Pruebas.EsAdmin ==true)
            {
                tbPage_Profile.Text = Pruebas.NombreUsuario;
            }
            else
            {
                tbPage_Profile.Text = Pruebas.NombreUsuario;

            }
        }

        private void frm_MainSubastApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            _socketClient.Disconnect();

            Application.Exit();
        }
    }
}
