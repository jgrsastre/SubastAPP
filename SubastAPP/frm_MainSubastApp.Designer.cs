namespace SubastAPP
{
    partial class frm_MainSubastApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainSubastApp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_TituloVentana = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_ResizedForm = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tbPage_Profile = new System.Windows.Forms.TabPage();
            this.tb_Auctions = new System.Windows.Forms.TabPage();
            this.tb_MyOffers = new System.Windows.Forms.TabPage();
            this.tbPage_MyAuctions = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_TituloVentana);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_ResizedForm);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1432, 55);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_TituloVentana
            // 
            this.lbl_TituloVentana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TituloVentana.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloVentana.ForeColor = System.Drawing.Color.White;
            this.lbl_TituloVentana.Location = new System.Drawing.Point(243, 9);
            this.lbl_TituloVentana.Name = "lbl_TituloVentana";
            this.lbl_TituloVentana.Size = new System.Drawing.Size(854, 29);
            this.lbl_TituloVentana.TabIndex = 3;
            this.lbl_TituloVentana.Text = "SubastApp";
            this.lbl_TituloVentana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TituloVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveForm);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(1293, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "__";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_ResizedForm
            // 
            this.btn_ResizedForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ResizedForm.FlatAppearance.BorderSize = 0;
            this.btn_ResizedForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResizedForm.ForeColor = System.Drawing.Color.Silver;
            this.btn_ResizedForm.Location = new System.Drawing.Point(1344, 12);
            this.btn_ResizedForm.Name = "btn_ResizedForm";
            this.btn_ResizedForm.Size = new System.Drawing.Size(34, 29);
            this.btn_ResizedForm.TabIndex = 1;
            this.btn_ResizedForm.Text = "▭";
            this.btn_ResizedForm.UseVisualStyleBackColor = true;
            this.btn_ResizedForm.Click += new System.EventHandler(this.btn_ResizedForm_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.Color.Silver;
            this.btn_Close.Location = new System.Drawing.Point(1395, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(34, 29);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 55);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1432, 43);
            this.materialTabSelector1.TabIndex = 6;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tbPage_Profile);
            this.materialTabControl1.Controls.Add(this.tb_Auctions);
            this.materialTabControl1.Controls.Add(this.tb_MyOffers);
            this.materialTabControl1.Controls.Add(this.tbPage_MyAuctions);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 98);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1432, 751);
            this.materialTabControl1.TabIndex = 7;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // tbPage_Profile
            // 
            this.tbPage_Profile.Location = new System.Drawing.Point(4, 22);
            this.tbPage_Profile.Name = "tbPage_Profile";
            this.tbPage_Profile.Padding = new System.Windows.Forms.Padding(3);
            this.tbPage_Profile.Size = new System.Drawing.Size(1424, 725);
            this.tbPage_Profile.TabIndex = 0;
            this.tbPage_Profile.Text = "Profile ʕ•͡_•ʔ";
            this.tbPage_Profile.UseVisualStyleBackColor = true;
            // 
            // tb_Auctions
            // 
            this.tb_Auctions.Location = new System.Drawing.Point(4, 22);
            this.tb_Auctions.Name = "tb_Auctions";
            this.tb_Auctions.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Auctions.Size = new System.Drawing.Size(1424, 725);
            this.tb_Auctions.TabIndex = 1;
            this.tb_Auctions.Text = "Auction List";
            this.tb_Auctions.UseVisualStyleBackColor = true;
            // 
            // tb_MyOffers
            // 
            this.tb_MyOffers.Location = new System.Drawing.Point(4, 22);
            this.tb_MyOffers.Name = "tb_MyOffers";
            this.tb_MyOffers.Padding = new System.Windows.Forms.Padding(3);
            this.tb_MyOffers.Size = new System.Drawing.Size(1424, 725);
            this.tb_MyOffers.TabIndex = 2;
            this.tb_MyOffers.Text = "My Offers";
            this.tb_MyOffers.UseVisualStyleBackColor = true;
            // 
            // tbPage_MyAuctions
            // 
            this.tbPage_MyAuctions.Location = new System.Drawing.Point(4, 22);
            this.tbPage_MyAuctions.Name = "tbPage_MyAuctions";
            this.tbPage_MyAuctions.Size = new System.Drawing.Size(1424, 725);
            this.tbPage_MyAuctions.TabIndex = 3;
            this.tbPage_MyAuctions.Text = "My Auctions";
            this.tbPage_MyAuctions.UseVisualStyleBackColor = true;
            // 
            // frm_MainSubastApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 849);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_MainSubastApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MainSubastApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MainSubastApp_FormClosing);
            this.Load += new System.EventHandler(this.frm_MainSubastApp_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TituloVentana;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_ResizedForm;
        private System.Windows.Forms.Button btn_Close;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tbPage_Profile;
        private System.Windows.Forms.TabPage tb_Auctions;
        private System.Windows.Forms.TabPage tb_MyOffers;
        private System.Windows.Forms.TabPage tbPage_MyAuctions;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}