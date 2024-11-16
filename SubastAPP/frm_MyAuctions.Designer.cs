namespace SubastAPP
{
    partial class frm_MyAuctions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_TitleAuction = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbox_CategoryAuction = new MetroFramework.Controls.MetroComboBox();
            this.dtime_StartingDateAuction = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbox_StartingPriceAuction = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_EndDateAuction = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_PreviewDescription = new System.Windows.Forms.TextBox();
            this.picbox_PreviewImageAuction = new System.Windows.Forms.PictureBox();
            this.lbl_PreviewPurchasePrice = new System.Windows.Forms.Label();
            this.lbl_PreviewTitleAuction = new System.Windows.Forms.Label();
            this.lbl_PreviewStartingPriceAuction = new System.Windows.Forms.Label();
            this.lbl_SignUp = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_PreviewStartingDateAuction = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_PreviewEndDateAuction = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_StartingPriceAuction = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_TituloVentana = new System.Windows.Forms.Label();
            this.txt_DirectPurchasePrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_ConfirmImage = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_DescriptionAuction = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ImageProduct = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_RegisterAuction = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_PreviewImageAuction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_TitleAuction
            // 
            this.txt_TitleAuction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TitleAuction.Depth = 0;
            this.txt_TitleAuction.Hint = "Title";
            this.txt_TitleAuction.Location = new System.Drawing.Point(482, 38);
            this.txt_TitleAuction.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_TitleAuction.Name = "txt_TitleAuction";
            this.txt_TitleAuction.PasswordChar = '\0';
            this.txt_TitleAuction.SelectedText = "";
            this.txt_TitleAuction.SelectionLength = 0;
            this.txt_TitleAuction.SelectionStart = 0;
            this.txt_TitleAuction.Size = new System.Drawing.Size(331, 23);
            this.txt_TitleAuction.TabIndex = 9;
            this.txt_TitleAuction.UseSystemPasswordChar = false;
            this.txt_TitleAuction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TitleAuction_KeyPress);
            this.txt_TitleAuction.TextChanged += new System.EventHandler(this.txt_TitleAuction_TextChanged);
            // 
            // cmbox_CategoryAuction
            // 
            this.cmbox_CategoryAuction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbox_CategoryAuction.FormattingEnabled = true;
            this.cmbox_CategoryAuction.ItemHeight = 23;
            this.cmbox_CategoryAuction.Items.AddRange(new object[] {
            "VEHICULO",
            "LINEA BLANCA"});
            this.cmbox_CategoryAuction.Location = new System.Drawing.Point(482, 76);
            this.cmbox_CategoryAuction.Name = "cmbox_CategoryAuction";
            this.cmbox_CategoryAuction.PromptText = "Category";
            this.cmbox_CategoryAuction.Size = new System.Drawing.Size(331, 29);
            this.cmbox_CategoryAuction.Style = MetroFramework.MetroColorStyle.Orange;
            this.cmbox_CategoryAuction.TabIndex = 10;
            this.cmbox_CategoryAuction.UseSelectable = true;
            this.cmbox_CategoryAuction.TextChanged += new System.EventHandler(this.cmbox_CategoryAuction_TextChanged);
            // 
            // dtime_StartingDateAuction
            // 
            this.dtime_StartingDateAuction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtime_StartingDateAuction.Location = new System.Drawing.Point(482, 166);
            this.dtime_StartingDateAuction.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtime_StartingDateAuction.Name = "dtime_StartingDateAuction";
            this.dtime_StartingDateAuction.Size = new System.Drawing.Size(200, 29);
            this.dtime_StartingDateAuction.Style = MetroFramework.MetroColorStyle.Orange;
            this.dtime_StartingDateAuction.TabIndex = 12;
            this.dtime_StartingDateAuction.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Starting date:";
            // 
            // cmbox_StartingPriceAuction
            // 
            this.cmbox_StartingPriceAuction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbox_StartingPriceAuction.FormattingEnabled = true;
            this.cmbox_StartingPriceAuction.ItemHeight = 23;
            this.cmbox_StartingPriceAuction.Items.AddRange(new object[] {
            "0",
            "50",
            "100",
            "300",
            "500",
            "800",
            "1000",
            "3000",
            "5000",
            "8000",
            "10000",
            "15000",
            "20000",
            "50000",
            "80000",
            "100000",
            "150000",
            "200000",
            "500000",
            "800000",
            "1000000",
            "2000000",
            "5000000",
            "8000000",
            "10000000"});
            this.cmbox_StartingPriceAuction.Location = new System.Drawing.Point(482, 318);
            this.cmbox_StartingPriceAuction.Name = "cmbox_StartingPriceAuction";
            this.cmbox_StartingPriceAuction.PromptText = "Select starting price";
            this.cmbox_StartingPriceAuction.Size = new System.Drawing.Size(331, 29);
            this.cmbox_StartingPriceAuction.Style = MetroFramework.MetroColorStyle.Orange;
            this.cmbox_StartingPriceAuction.TabIndex = 14;
            this.cmbox_StartingPriceAuction.UseSelectable = true;
            this.cmbox_StartingPriceAuction.TextChanged += new System.EventHandler(this.cmbox_StartingPriceAuction_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "End date:";
            // 
            // lbl_EndDateAuction
            // 
            this.lbl_EndDateAuction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_EndDateAuction.AutoSize = true;
            this.lbl_EndDateAuction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EndDateAuction.ForeColor = System.Drawing.Color.Gray;
            this.lbl_EndDateAuction.Location = new System.Drawing.Point(478, 271);
            this.lbl_EndDateAuction.Name = "lbl_EndDateAuction";
            this.lbl_EndDateAuction.Size = new System.Drawing.Size(72, 19);
            this.lbl_EndDateAuction.TabIndex = 16;
            this.lbl_EndDateAuction.Text = "undated";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_Category);
            this.panel1.Controls.Add(this.txt_PreviewDescription);
            this.panel1.Controls.Add(this.picbox_PreviewImageAuction);
            this.panel1.Controls.Add(this.lbl_PreviewPurchasePrice);
            this.panel1.Controls.Add(this.lbl_PreviewTitleAuction);
            this.panel1.Controls.Add(this.lbl_PreviewStartingPriceAuction);
            this.panel1.Controls.Add(this.lbl_SignUp);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lbl_PreviewStartingDateAuction);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbl_PreviewEndDateAuction);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(819, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 424);
            this.panel1.TabIndex = 17;
            // 
            // txt_PreviewDescription
            // 
            this.txt_PreviewDescription.Location = new System.Drawing.Point(7, 254);
            this.txt_PreviewDescription.Multiline = true;
            this.txt_PreviewDescription.Name = "txt_PreviewDescription";
            this.txt_PreviewDescription.ReadOnly = true;
            this.txt_PreviewDescription.Size = new System.Drawing.Size(521, 146);
            this.txt_PreviewDescription.TabIndex = 31;
            // 
            // picbox_PreviewImageAuction
            // 
            this.picbox_PreviewImageAuction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox_PreviewImageAuction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.picbox_PreviewImageAuction.Location = new System.Drawing.Point(317, 50);
            this.picbox_PreviewImageAuction.Name = "picbox_PreviewImageAuction";
            this.picbox_PreviewImageAuction.Size = new System.Drawing.Size(217, 189);
            this.picbox_PreviewImageAuction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_PreviewImageAuction.TabIndex = 39;
            this.picbox_PreviewImageAuction.TabStop = false;
            // 
            // lbl_PreviewPurchasePrice
            // 
            this.lbl_PreviewPurchasePrice.AutoSize = true;
            this.lbl_PreviewPurchasePrice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PreviewPurchasePrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_PreviewPurchasePrice.Location = new System.Drawing.Point(110, 220);
            this.lbl_PreviewPurchasePrice.Name = "lbl_PreviewPurchasePrice";
            this.lbl_PreviewPurchasePrice.Size = new System.Drawing.Size(94, 15);
            this.lbl_PreviewPurchasePrice.TabIndex = 38;
            this.lbl_PreviewPurchasePrice.Text = "Purchase price";
            // 
            // lbl_PreviewTitleAuction
            // 
            this.lbl_PreviewTitleAuction.AutoSize = true;
            this.lbl_PreviewTitleAuction.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PreviewTitleAuction.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_PreviewTitleAuction.Location = new System.Drawing.Point(110, 13);
            this.lbl_PreviewTitleAuction.Name = "lbl_PreviewTitleAuction";
            this.lbl_PreviewTitleAuction.Size = new System.Drawing.Size(31, 15);
            this.lbl_PreviewTitleAuction.TabIndex = 27;
            this.lbl_PreviewTitleAuction.Text = "Title";
            // 
            // lbl_PreviewStartingPriceAuction
            // 
            this.lbl_PreviewStartingPriceAuction.AutoSize = true;
            this.lbl_PreviewStartingPriceAuction.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PreviewStartingPriceAuction.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_PreviewStartingPriceAuction.Location = new System.Drawing.Point(110, 175);
            this.lbl_PreviewStartingPriceAuction.Name = "lbl_PreviewStartingPriceAuction";
            this.lbl_PreviewStartingPriceAuction.Size = new System.Drawing.Size(85, 15);
            this.lbl_PreviewStartingPriceAuction.TabIndex = 37;
            this.lbl_PreviewStartingPriceAuction.Text = "Starting Price";
            // 
            // lbl_SignUp
            // 
            this.lbl_SignUp.AutoSize = true;
            this.lbl_SignUp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SignUp.Location = new System.Drawing.Point(10, 13);
            this.lbl_SignUp.Name = "lbl_SignUp";
            this.lbl_SignUp.Size = new System.Drawing.Size(93, 16);
            this.lbl_SignUp.TabIndex = 26;
            this.lbl_SignUp.Text = "Product Detail:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Start date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = " End date:";
            // 
            // lbl_PreviewStartingDateAuction
            // 
            this.lbl_PreviewStartingDateAuction.AutoSize = true;
            this.lbl_PreviewStartingDateAuction.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PreviewStartingDateAuction.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_PreviewStartingDateAuction.Location = new System.Drawing.Point(110, 92);
            this.lbl_PreviewStartingDateAuction.Name = "lbl_PreviewStartingDateAuction";
            this.lbl_PreviewStartingDateAuction.Size = new System.Drawing.Size(80, 15);
            this.lbl_PreviewStartingDateAuction.TabIndex = 30;
            this.lbl_PreviewStartingDateAuction.Text = "Starting date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Purchase price:";
            // 
            // lbl_PreviewEndDateAuction
            // 
            this.lbl_PreviewEndDateAuction.AutoSize = true;
            this.lbl_PreviewEndDateAuction.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PreviewEndDateAuction.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_PreviewEndDateAuction.Location = new System.Drawing.Point(110, 134);
            this.lbl_PreviewEndDateAuction.Name = "lbl_PreviewEndDateAuction";
            this.lbl_PreviewEndDateAuction.Size = new System.Drawing.Size(56, 15);
            this.lbl_PreviewEndDateAuction.TabIndex = 31;
            this.lbl_PreviewEndDateAuction.Text = "End date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Starting price:";
            // 
            // txt_StartingPriceAuction
            // 
            this.txt_StartingPriceAuction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_StartingPriceAuction.Depth = 0;
            this.txt_StartingPriceAuction.Hint = "Write the starting price";
            this.txt_StartingPriceAuction.Location = new System.Drawing.Point(482, 402);
            this.txt_StartingPriceAuction.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_StartingPriceAuction.Name = "txt_StartingPriceAuction";
            this.txt_StartingPriceAuction.PasswordChar = '\0';
            this.txt_StartingPriceAuction.SelectedText = "";
            this.txt_StartingPriceAuction.SelectionLength = 0;
            this.txt_StartingPriceAuction.SelectionStart = 0;
            this.txt_StartingPriceAuction.Size = new System.Drawing.Size(331, 23);
            this.txt_StartingPriceAuction.TabIndex = 21;
            this.txt_StartingPriceAuction.UseSystemPasswordChar = false;
            this.txt_StartingPriceAuction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_StartingPriceAuction_KeyPress);
            this.txt_StartingPriceAuction.TextChanged += new System.EventHandler(this.txt_StartingPriceAuction_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "or";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5,
            this.Column7});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(423, 615);
            this.dataGridView1.TabIndex = 24;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Title Auction";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Last Offer";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Purchase Price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Start Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "End Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Close";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.lbl_TituloVentana);
            this.panel2.Location = new System.Drawing.Point(819, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 55);
            this.panel2.TabIndex = 18;
            // 
            // lbl_TituloVentana
            // 
            this.lbl_TituloVentana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TituloVentana.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloVentana.ForeColor = System.Drawing.Color.White;
            this.lbl_TituloVentana.Location = new System.Drawing.Point(3, 9);
            this.lbl_TituloVentana.Name = "lbl_TituloVentana";
            this.lbl_TituloVentana.Size = new System.Drawing.Size(533, 40);
            this.lbl_TituloVentana.TabIndex = 3;
            this.lbl_TituloVentana.Text = "Preview";
            this.lbl_TituloVentana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_DirectPurchasePrice
            // 
            this.txt_DirectPurchasePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DirectPurchasePrice.Depth = 0;
            this.txt_DirectPurchasePrice.Hint = "Direct purchase price";
            this.txt_DirectPurchasePrice.Location = new System.Drawing.Point(483, 464);
            this.txt_DirectPurchasePrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_DirectPurchasePrice.Name = "txt_DirectPurchasePrice";
            this.txt_DirectPurchasePrice.PasswordChar = '\0';
            this.txt_DirectPurchasePrice.SelectedText = "";
            this.txt_DirectPurchasePrice.SelectionLength = 0;
            this.txt_DirectPurchasePrice.SelectionStart = 0;
            this.txt_DirectPurchasePrice.Size = new System.Drawing.Size(200, 23);
            this.txt_DirectPurchasePrice.TabIndex = 25;
            this.txt_DirectPurchasePrice.UseSystemPasswordChar = false;
            this.txt_DirectPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_StartingPriceAuction_KeyPress);
            this.txt_DirectPurchasePrice.TextChanged += new System.EventHandler(this.txt_DirectPurchasePrice_TextChanged);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(689, 455);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 42);
            this.label15.TabIndex = 26;
            this.label15.Text = "ⓘ";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(479, 510);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 19);
            this.label16.TabIndex = 27;
            this.label16.Text = "Description:";
            // 
            // lbl_ConfirmImage
            // 
            this.lbl_ConfirmImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ConfirmImage.AutoSize = true;
            this.lbl_ConfirmImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ConfirmImage.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConfirmImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.lbl_ConfirmImage.Location = new System.Drawing.Point(689, 663);
            this.lbl_ConfirmImage.Name = "lbl_ConfirmImage";
            this.lbl_ConfirmImage.Size = new System.Drawing.Size(56, 42);
            this.lbl_ConfirmImage.TabIndex = 28;
            this.lbl_ConfirmImage.Text = "✖";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(172)))), ((int)(((byte)(24)))));
            this.panel3.Location = new System.Drawing.Point(441, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 783);
            this.panel3.TabIndex = 29;
            // 
            // txt_DescriptionAuction
            // 
            this.txt_DescriptionAuction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DescriptionAuction.Location = new System.Drawing.Point(482, 545);
            this.txt_DescriptionAuction.Multiline = true;
            this.txt_DescriptionAuction.Name = "txt_DescriptionAuction";
            this.txt_DescriptionAuction.Size = new System.Drawing.Size(331, 101);
            this.txt_DescriptionAuction.TabIndex = 30;
            this.txt_DescriptionAuction.TextChanged += new System.EventHandler(this.txt_DescriptionAuction_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(172)))), ((int)(((byte)(24)))));
            this.label3.Location = new System.Drawing.Point(51, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 46);
            this.label3.TabIndex = 31;
            this.label3.Text = "Manage auctions";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ImageProduct
            // 
            this.btn_ImageProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ImageProduct.Animated = true;
            this.btn_ImageProduct.AnimationHoverSpeed = 0.07F;
            this.btn_ImageProduct.AnimationSpeed = 0.03F;
            this.btn_ImageProduct.BackColor = System.Drawing.Color.Transparent;
            this.btn_ImageProduct.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.btn_ImageProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(160)))));
            this.btn_ImageProduct.BorderSize = 1;
            this.btn_ImageProduct.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_ImageProduct.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_ImageProduct.CheckedForeColor = System.Drawing.Color.White;
            this.btn_ImageProduct.CheckedImage = null;
            this.btn_ImageProduct.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_ImageProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ImageProduct.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ImageProduct.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImageProduct.ForeColor = System.Drawing.Color.White;
            this.btn_ImageProduct.Image = null;
            this.btn_ImageProduct.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_ImageProduct.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_ImageProduct.Location = new System.Drawing.Point(482, 663);
            this.btn_ImageProduct.Name = "btn_ImageProduct";
            this.btn_ImageProduct.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(172)))), ((int)(((byte)(24)))));
            this.btn_ImageProduct.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.btn_ImageProduct.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ImageProduct.OnHoverImage = null;
            this.btn_ImageProduct.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_ImageProduct.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ImageProduct.Radius = 10;
            this.btn_ImageProduct.Size = new System.Drawing.Size(200, 42);
            this.btn_ImageProduct.TabIndex = 48;
            this.btn_ImageProduct.Text = "Select an image";
            this.btn_ImageProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ImageProduct.Click += new System.EventHandler(this.btn_ImageProduct_Click);
            // 
            // btn_RegisterAuction
            // 
            this.btn_RegisterAuction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RegisterAuction.Animated = true;
            this.btn_RegisterAuction.AnimationHoverSpeed = 0.07F;
            this.btn_RegisterAuction.AnimationSpeed = 0.03F;
            this.btn_RegisterAuction.BackColor = System.Drawing.Color.Transparent;
            this.btn_RegisterAuction.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.btn_RegisterAuction.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(160)))));
            this.btn_RegisterAuction.BorderSize = 1;
            this.btn_RegisterAuction.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_RegisterAuction.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_RegisterAuction.CheckedForeColor = System.Drawing.Color.White;
            this.btn_RegisterAuction.CheckedImage = null;
            this.btn_RegisterAuction.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_RegisterAuction.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_RegisterAuction.FocusedColor = System.Drawing.Color.Empty;
            this.btn_RegisterAuction.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegisterAuction.ForeColor = System.Drawing.Color.White;
            this.btn_RegisterAuction.Image = null;
            this.btn_RegisterAuction.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_RegisterAuction.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_RegisterAuction.Location = new System.Drawing.Point(1176, 510);
            this.btn_RegisterAuction.Name = "btn_RegisterAuction";
            this.btn_RegisterAuction.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(172)))), ((int)(((byte)(24)))));
            this.btn_RegisterAuction.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.btn_RegisterAuction.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_RegisterAuction.OnHoverImage = null;
            this.btn_RegisterAuction.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_RegisterAuction.OnPressedColor = System.Drawing.Color.Black;
            this.btn_RegisterAuction.Radius = 10;
            this.btn_RegisterAuction.Size = new System.Drawing.Size(182, 42);
            this.btn_RegisterAuction.TabIndex = 49;
            this.btn_RegisterAuction.Text = "Register Auction";
            this.btn_RegisterAuction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_RegisterAuction.Click += new System.EventHandler(this.btn_RegisterAuction_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Category:";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Category.Location = new System.Drawing.Point(110, 51);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(58, 15);
            this.lbl_Category.TabIndex = 41;
            this.lbl_Category.Text = "Category";
            // 
            // frm_MyAuctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 820);
            this.Controls.Add(this.btn_RegisterAuction);
            this.Controls.Add(this.btn_ImageProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_DescriptionAuction);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbl_ConfirmImage);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_DirectPurchasePrice);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_StartingPriceAuction);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_EndDateAuction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbox_StartingPriceAuction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtime_StartingDateAuction);
            this.Controls.Add(this.cmbox_CategoryAuction);
            this.Controls.Add(this.txt_TitleAuction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MyAuctions";
            this.Text = "frm_MyAuctions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_PreviewImageAuction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txt_TitleAuction;
        private MetroFramework.Controls.MetroComboBox cmbox_CategoryAuction;
        private MetroFramework.Controls.MetroDateTime dtime_StartingDateAuction;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cmbox_StartingPriceAuction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_EndDateAuction;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_StartingPriceAuction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_PreviewPurchasePrice;
        private System.Windows.Forms.Label lbl_PreviewTitleAuction;
        private System.Windows.Forms.Label lbl_PreviewStartingPriceAuction;
        private System.Windows.Forms.Label lbl_SignUp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_PreviewStartingDateAuction;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_PreviewEndDateAuction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_TituloVentana;
        private System.Windows.Forms.PictureBox picbox_PreviewImageAuction;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_DirectPurchasePrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_ConfirmImage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_DescriptionAuction;
        private System.Windows.Forms.TextBox txt_PreviewDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private Guna.UI.WinForms.GunaAdvenceButton btn_ImageProduct;
        private Guna.UI.WinForms.GunaAdvenceButton btn_RegisterAuction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Category;
    }
}