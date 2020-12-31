namespace Pooranyash_SmartPhone
{
    partial class frmProductRegistration
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
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbPriceDetails = new System.Windows.Forms.GroupBox();
            this.txtPurchaseRate = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtMRP = new System.Windows.Forms.TextBox();
            this.txtMOP = new System.Windows.Forms.TextBox();
            this.txtCGST = new System.Windows.Forms.TextBox();
            this.txtSGST = new System.Windows.Forms.TextBox();
            this.cmbGST = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblSGST = new System.Windows.Forms.Label();
            this.lblCGST = new System.Windows.Forms.Label();
            this.lblTotalGST = new System.Windows.Forms.Label();
            this.lblMOP = new System.Windows.Forms.Label();
            this.lblMRP = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblPurchaseRate = new System.Windows.Forms.Label();
            this.gbProductDetails = new System.Windows.Forms.GroupBox();
            this.cmbBrandName = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtStockLimit = new System.Windows.Forms.TextBox();
            this.txtHSNCode = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.lblHSNCode = new System.Windows.Forms.Label();
            this.lblStockLimit = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.gbSearchBy = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearchProduct = new System.Windows.Forms.ComboBox();
            this.lblProductSearch = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbPriceDetails.SuspendLayout();
            this.gbProductDetails.SuspendLayout();
            this.gbSearchBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column7,
            this.Column6,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dgvBill.Location = new System.Drawing.Point(639, 309);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.Size = new System.Drawing.Size(598, 392);
            this.dgvBill.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 107;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 129;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Brand Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 119;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "HSN Code";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 106;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Color";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 71;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Stock Limit";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 111;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quantity";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 92;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Purchase Rate";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 132;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Sale Price";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 101;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "MRP";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 71;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "MOP";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 71;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Total GST";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 103;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "CGST";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 76;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "SGST";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 74;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbPriceDetails);
            this.panel1.Controls.Add(this.gbProductDetails);
            this.panel1.Location = new System.Drawing.Point(34, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 569);
            this.panel1.TabIndex = 25;
            // 
            // gbPriceDetails
            // 
            this.gbPriceDetails.Controls.Add(this.txtPurchaseRate);
            this.gbPriceDetails.Controls.Add(this.txtSalePrice);
            this.gbPriceDetails.Controls.Add(this.txtMRP);
            this.gbPriceDetails.Controls.Add(this.txtMOP);
            this.gbPriceDetails.Controls.Add(this.txtCGST);
            this.gbPriceDetails.Controls.Add(this.txtSGST);
            this.gbPriceDetails.Controls.Add(this.cmbGST);
            this.gbPriceDetails.Controls.Add(this.btnSave);
            this.gbPriceDetails.Controls.Add(this.btnUpdate);
            this.gbPriceDetails.Controls.Add(this.lblSGST);
            this.gbPriceDetails.Controls.Add(this.lblCGST);
            this.gbPriceDetails.Controls.Add(this.lblTotalGST);
            this.gbPriceDetails.Controls.Add(this.lblMOP);
            this.gbPriceDetails.Controls.Add(this.lblMRP);
            this.gbPriceDetails.Controls.Add(this.lblSalePrice);
            this.gbPriceDetails.Controls.Add(this.lblPurchaseRate);
            this.gbPriceDetails.Location = new System.Drawing.Point(16, 320);
            this.gbPriceDetails.Name = "gbPriceDetails";
            this.gbPriceDetails.Size = new System.Drawing.Size(511, 235);
            this.gbPriceDetails.TabIndex = 0;
            this.gbPriceDetails.TabStop = false;
            this.gbPriceDetails.Text = "Price Details";
            // 
            // txtPurchaseRate
            // 
            this.txtPurchaseRate.Location = new System.Drawing.Point(125, 43);
            this.txtPurchaseRate.Name = "txtPurchaseRate";
            this.txtPurchaseRate.Size = new System.Drawing.Size(100, 26);
            this.txtPurchaseRate.TabIndex = 0;
            this.txtPurchaseRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPurchaseRate_KeyDown);
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(125, 84);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(100, 26);
            this.txtSalePrice.TabIndex = 1;
            this.txtSalePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalePrice_KeyDown);
            // 
            // txtMRP
            // 
            this.txtMRP.Location = new System.Drawing.Point(125, 133);
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.Size = new System.Drawing.Size(100, 26);
            this.txtMRP.TabIndex = 2;
            this.txtMRP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMRP_KeyDown);
            // 
            // txtMOP
            // 
            this.txtMOP.Location = new System.Drawing.Point(125, 178);
            this.txtMOP.Name = "txtMOP";
            this.txtMOP.Size = new System.Drawing.Size(100, 26);
            this.txtMOP.TabIndex = 3;
            this.txtMOP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMOP_KeyDown);
            // 
            // txtCGST
            // 
            this.txtCGST.Location = new System.Drawing.Point(383, 84);
            this.txtCGST.Name = "txtCGST";
            this.txtCGST.Size = new System.Drawing.Size(100, 26);
            this.txtCGST.TabIndex = 5;
            this.txtCGST.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCGST_KeyDown);
            // 
            // txtSGST
            // 
            this.txtSGST.Location = new System.Drawing.Point(383, 133);
            this.txtSGST.Name = "txtSGST";
            this.txtSGST.Size = new System.Drawing.Size(100, 26);
            this.txtSGST.TabIndex = 6;
            this.txtSGST.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSGST_KeyDown);
            // 
            // cmbGST
            // 
            this.cmbGST.FormattingEnabled = true;
            this.cmbGST.Location = new System.Drawing.Point(383, 42);
            this.cmbGST.Name = "cmbGST";
            this.cmbGST.Size = new System.Drawing.Size(100, 27);
            this.cmbGST.TabIndex = 4;
            this.cmbGST.SelectedIndexChanged += new System.EventHandler(this.cmbGST_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(268, 198);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 31);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(392, 198);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 31);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lblSGST
            // 
            this.lblSGST.AutoSize = true;
            this.lblSGST.Location = new System.Drawing.Point(313, 140);
            this.lblSGST.Name = "lblSGST";
            this.lblSGST.Size = new System.Drawing.Size(49, 19);
            this.lblSGST.TabIndex = 6;
            this.lblSGST.Text = "SGST";
            // 
            // lblCGST
            // 
            this.lblCGST.AutoSize = true;
            this.lblCGST.Location = new System.Drawing.Point(311, 91);
            this.lblCGST.Name = "lblCGST";
            this.lblCGST.Size = new System.Drawing.Size(51, 19);
            this.lblCGST.TabIndex = 5;
            this.lblCGST.Text = "CGST";
            // 
            // lblTotalGST
            // 
            this.lblTotalGST.AutoSize = true;
            this.lblTotalGST.Location = new System.Drawing.Point(284, 50);
            this.lblTotalGST.Name = "lblTotalGST";
            this.lblTotalGST.Size = new System.Drawing.Size(78, 19);
            this.lblTotalGST.TabIndex = 4;
            this.lblTotalGST.Text = "Total GST";
            // 
            // lblMOP
            // 
            this.lblMOP.AutoSize = true;
            this.lblMOP.Location = new System.Drawing.Point(6, 181);
            this.lblMOP.Name = "lblMOP";
            this.lblMOP.Size = new System.Drawing.Size(46, 19);
            this.lblMOP.TabIndex = 3;
            this.lblMOP.Text = "MOP";
            // 
            // lblMRP
            // 
            this.lblMRP.AutoSize = true;
            this.lblMRP.Location = new System.Drawing.Point(6, 140);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(46, 19);
            this.lblMRP.TabIndex = 2;
            this.lblMRP.Text = "MRP";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(6, 91);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(76, 19);
            this.lblSalePrice.TabIndex = 1;
            this.lblSalePrice.Text = "Sale Price";
            // 
            // lblPurchaseRate
            // 
            this.lblPurchaseRate.AutoSize = true;
            this.lblPurchaseRate.Location = new System.Drawing.Point(6, 43);
            this.lblPurchaseRate.Name = "lblPurchaseRate";
            this.lblPurchaseRate.Size = new System.Drawing.Size(107, 19);
            this.lblPurchaseRate.TabIndex = 0;
            this.lblPurchaseRate.Text = "Purchase Rate";
            // 
            // gbProductDetails
            // 
            this.gbProductDetails.Controls.Add(this.cmbBrandName);
            this.gbProductDetails.Controls.Add(this.cmbColor);
            this.gbProductDetails.Controls.Add(this.txtProductName);
            this.gbProductDetails.Controls.Add(this.txtStockLimit);
            this.gbProductDetails.Controls.Add(this.txtHSNCode);
            this.gbProductDetails.Controls.Add(this.txtQuantity);
            this.gbProductDetails.Controls.Add(this.lblProductName);
            this.gbProductDetails.Controls.Add(this.lblBrandName);
            this.gbProductDetails.Controls.Add(this.lblHSNCode);
            this.gbProductDetails.Controls.Add(this.lblStockLimit);
            this.gbProductDetails.Controls.Add(this.lblColor);
            this.gbProductDetails.Controls.Add(this.lblQuantity);
            this.gbProductDetails.Location = new System.Drawing.Point(3, 76);
            this.gbProductDetails.Name = "gbProductDetails";
            this.gbProductDetails.Size = new System.Drawing.Size(524, 238);
            this.gbProductDetails.TabIndex = 0;
            this.gbProductDetails.TabStop = false;
            this.gbProductDetails.Text = "Product Details";
            // 
            // cmbBrandName
            // 
            this.cmbBrandName.FormattingEnabled = true;
            this.cmbBrandName.Location = new System.Drawing.Point(126, 81);
            this.cmbBrandName.Name = "cmbBrandName";
            this.cmbBrandName.Size = new System.Drawing.Size(121, 27);
            this.cmbBrandName.TabIndex = 1;
            this.cmbBrandName.SelectedIndexChanged += new System.EventHandler(this.cmbBrandName_SelectedIndexChanged);
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(407, 130);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(100, 27);
            this.cmbColor.TabIndex = 4;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(125, 29);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(382, 26);
            this.txtProductName.TabIndex = 0;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // txtStockLimit
            // 
            this.txtStockLimit.Location = new System.Drawing.Point(125, 182);
            this.txtStockLimit.Name = "txtStockLimit";
            this.txtStockLimit.Size = new System.Drawing.Size(121, 26);
            this.txtStockLimit.TabIndex = 3;
            this.txtStockLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStockLimit_KeyDown);
            // 
            // txtHSNCode
            // 
            this.txtHSNCode.Location = new System.Drawing.Point(126, 133);
            this.txtHSNCode.Name = "txtHSNCode";
            this.txtHSNCode.Size = new System.Drawing.Size(121, 26);
            this.txtHSNCode.TabIndex = 2;
            this.txtHSNCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHSNCode_KeyDown);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(407, 182);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 26);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(6, 36);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(104, 19);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Location = new System.Drawing.Point(6, 84);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(94, 19);
            this.lblBrandName.TabIndex = 2;
            this.lblBrandName.Text = "Brand Name";
            // 
            // lblHSNCode
            // 
            this.lblHSNCode.AutoSize = true;
            this.lblHSNCode.Location = new System.Drawing.Point(6, 142);
            this.lblHSNCode.Name = "lblHSNCode";
            this.lblHSNCode.Size = new System.Drawing.Size(81, 19);
            this.lblHSNCode.TabIndex = 3;
            this.lblHSNCode.Text = "HSN Code";
            // 
            // lblStockLimit
            // 
            this.lblStockLimit.AutoSize = true;
            this.lblStockLimit.Location = new System.Drawing.Point(6, 189);
            this.lblStockLimit.Name = "lblStockLimit";
            this.lblStockLimit.Size = new System.Drawing.Size(86, 19);
            this.lblStockLimit.TabIndex = 4;
            this.lblStockLimit.Text = "Stock Limit";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(313, 138);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(46, 19);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Color";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(295, 185);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(67, 19);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity";
            // 
            // gbSearchBy
            // 
            this.gbSearchBy.Controls.Add(this.btnRefresh);
            this.gbSearchBy.Controls.Add(this.btnSearch);
            this.gbSearchBy.Controls.Add(this.cmbSearchProduct);
            this.gbSearchBy.Controls.Add(this.lblProductSearch);
            this.gbSearchBy.Location = new System.Drawing.Point(639, 150);
            this.gbSearchBy.Name = "gbSearchBy";
            this.gbSearchBy.Size = new System.Drawing.Size(598, 133);
            this.gbSearchBy.TabIndex = 24;
            this.gbSearchBy.TabStop = false;
            this.gbSearchBy.Text = "Search By";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(229, 96);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 31);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(338, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSearchProduct
            // 
            this.cmbSearchProduct.FormattingEnabled = true;
            this.cmbSearchProduct.Location = new System.Drawing.Point(139, 62);
            this.cmbSearchProduct.Name = "cmbSearchProduct";
            this.cmbSearchProduct.Size = new System.Drawing.Size(288, 27);
            this.cmbSearchProduct.TabIndex = 0;
            // 
            // lblProductSearch
            // 
            this.lblProductSearch.AutoSize = true;
            this.lblProductSearch.Location = new System.Drawing.Point(16, 70);
            this.lblProductSearch.Name = "lblProductSearch";
            this.lblProductSearch.Size = new System.Drawing.Size(104, 19);
            this.lblProductSearch.TabIndex = 16;
            this.lblProductSearch.Text = "Product Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pooranyash_SmartPhone.Properties.Resources.mobileshop;
            this.pictureBox2.Location = new System.Drawing.Point(96, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(380, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.Image = global::Pooranyash_SmartPhone.Properties.Resources.caltime;
            this.pictureBox1.Location = new System.Drawing.Point(762, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(988, 71);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(112, 26);
            this.dtpDate.TabIndex = 30;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "hh:mm:ssss";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(988, 21);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(110, 26);
            this.dtpTime.TabIndex = 29;
            // 
            // frmProductRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbSearchBy);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbPriceDetails.ResumeLayout(false);
            this.gbPriceDetails.PerformLayout();
            this.gbProductDetails.ResumeLayout(false);
            this.gbProductDetails.PerformLayout();
            this.gbSearchBy.ResumeLayout(false);
            this.gbSearchBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbPriceDetails;
        private System.Windows.Forms.TextBox txtPurchaseRate;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.TextBox txtMRP;
        private System.Windows.Forms.TextBox txtMOP;
        private System.Windows.Forms.TextBox txtCGST;
        private System.Windows.Forms.TextBox txtSGST;
        private System.Windows.Forms.ComboBox cmbGST;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblSGST;
        private System.Windows.Forms.Label lblCGST;
        private System.Windows.Forms.Label lblTotalGST;
        private System.Windows.Forms.Label lblMOP;
        private System.Windows.Forms.Label lblMRP;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblPurchaseRate;
        private System.Windows.Forms.GroupBox gbProductDetails;
        private System.Windows.Forms.ComboBox cmbBrandName;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtStockLimit;
        private System.Windows.Forms.TextBox txtHSNCode;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblHSNCode;
        private System.Windows.Forms.Label lblStockLimit;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.GroupBox gbSearchBy;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearchProduct;
        private System.Windows.Forms.Label lblProductSearch;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
    }
}