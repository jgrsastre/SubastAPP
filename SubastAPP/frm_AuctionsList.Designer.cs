namespace SubastAPP
{
    partial class frm_AuctionsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.c_Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.c_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_StartingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_BtnDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_LoadAuctions = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_Image,
            this.c_Title,
            this.c_Description,
            this.c_StartingPrice,
            this.c_StartDate,
            this.c_EndDate,
            this.c_Category,
            this.c_PurchasePrice,
            this.c_BtnDetail});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1346, 719);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // c_Image
            // 
            this.c_Image.HeaderText = "Image";
            this.c_Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.c_Image.Name = "c_Image";
            this.c_Image.ReadOnly = true;
            this.c_Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c_Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // c_Title
            // 
            this.c_Title.HeaderText = "Title";
            this.c_Title.Name = "c_Title";
            this.c_Title.ReadOnly = true;
            // 
            // c_Description
            // 
            this.c_Description.HeaderText = "Description";
            this.c_Description.Name = "c_Description";
            this.c_Description.ReadOnly = true;
            // 
            // c_StartingPrice
            // 
            this.c_StartingPrice.HeaderText = "Starting Price";
            this.c_StartingPrice.Name = "c_StartingPrice";
            this.c_StartingPrice.ReadOnly = true;
            // 
            // c_StartDate
            // 
            this.c_StartDate.HeaderText = "Start Date";
            this.c_StartDate.Name = "c_StartDate";
            this.c_StartDate.ReadOnly = true;
            // 
            // c_EndDate
            // 
            this.c_EndDate.HeaderText = "End Date";
            this.c_EndDate.Name = "c_EndDate";
            this.c_EndDate.ReadOnly = true;
            // 
            // c_Category
            // 
            this.c_Category.HeaderText = "Category";
            this.c_Category.Name = "c_Category";
            this.c_Category.ReadOnly = true;
            // 
            // c_PurchasePrice
            // 
            this.c_PurchasePrice.HeaderText = "Purchase Price";
            this.c_PurchasePrice.Name = "c_PurchasePrice";
            this.c_PurchasePrice.ReadOnly = true;
            // 
            // c_BtnDetail
            // 
            this.c_BtnDetail.HeaderText = "Detail";
            this.c_BtnDetail.Name = "c_BtnDetail";
            this.c_BtnDetail.ReadOnly = true;
            this.c_BtnDetail.Text = "Details";
            this.c_BtnDetail.UseColumnTextForButtonValue = true;
            // 
            // btn_LoadAuctions
            // 
            this.btn_LoadAuctions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LoadAuctions.Animated = true;
            this.btn_LoadAuctions.AnimationHoverSpeed = 0.07F;
            this.btn_LoadAuctions.AnimationSpeed = 0.03F;
            this.btn_LoadAuctions.BackColor = System.Drawing.Color.Transparent;
            this.btn_LoadAuctions.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.btn_LoadAuctions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.btn_LoadAuctions.BorderSize = 1;
            this.btn_LoadAuctions.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_LoadAuctions.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_LoadAuctions.CheckedForeColor = System.Drawing.Color.White;
            this.btn_LoadAuctions.CheckedImage = null;
            this.btn_LoadAuctions.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_LoadAuctions.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_LoadAuctions.FocusedColor = System.Drawing.Color.Empty;
            this.btn_LoadAuctions.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadAuctions.ForeColor = System.Drawing.Color.White;
            this.btn_LoadAuctions.Image = null;
            this.btn_LoadAuctions.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_LoadAuctions.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_LoadAuctions.Location = new System.Drawing.Point(1133, 25);
            this.btn_LoadAuctions.Name = "btn_LoadAuctions";
            this.btn_LoadAuctions.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(172)))), ((int)(((byte)(24)))));
            this.btn_LoadAuctions.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.btn_LoadAuctions.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_LoadAuctions.OnHoverImage = null;
            this.btn_LoadAuctions.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_LoadAuctions.OnPressedColor = System.Drawing.Color.Black;
            this.btn_LoadAuctions.Radius = 10;
            this.btn_LoadAuctions.Size = new System.Drawing.Size(225, 42);
            this.btn_LoadAuctions.TabIndex = 50;
            this.btn_LoadAuctions.Text = "Load Auction List";
            this.btn_LoadAuctions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_LoadAuctions.Click += new System.EventHandler(this.btn_LoadAuctions_Click);
            // 
            // frm_AuctionsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 820);
            this.Controls.Add(this.btn_LoadAuctions);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AuctionsList";
            this.Text = "frm_AuctionsList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn c_Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_StartingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_PurchasePrice;
        private System.Windows.Forms.DataGridViewButtonColumn c_BtnDetail;
        private Guna.UI.WinForms.GunaAdvenceButton btn_LoadAuctions;
    }
}