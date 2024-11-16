﻿using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubastAPP
{
    public partial class frm_UserProfile : Form
    {
        public frm_UserProfile()
        {
            InitializeComponent();
        }
        
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            // Llamar al método estático para cerrar sesión
            ClienteSession.CerrarSesion();

            // Cerramos la aplicación
            Application.Exit();
        }
    }
}
