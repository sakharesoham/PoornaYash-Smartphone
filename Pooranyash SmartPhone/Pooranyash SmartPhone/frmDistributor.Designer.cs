namespace Pooranyash_SmartPhone
{
    partial class frmDistributor
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvDistributor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDist = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCit = new System.Windows.Forms.TextBox();
            this.txtContNo = new System.Windows.Forms.TextBox();
            this.txtCompAddress = new System.Windows.Forms.TextBox();
            this.txtContName = new System.Windows.Forms.TextBox();
            this.txtCompGST = new System.Windows.Forms.TextBox();
            this.txtDistName = new System.Windows.Forms.TextBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.cmbbrand = new System.Windows.Forms.ComboBox();
            this.rbtnUR = new System.Windows.Forms.RadioButton();
            this.rbtnR = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAccoNo = new System.Windows.Forms.TextBox();
            this.txtbMICR = new System.Windows.Forms.TextBox();
            this.txtbIFSC = new System.Windows.Forms.TextBox();
            this.txtbankname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistributor)).BeginInit();
            this.grpDist.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDistributor
            // 
            this.dgvDistributor.AllowUserToAddRows = false;
            this.dgvDistributor.AllowUserToDeleteRows = false;
            this.dgvDistributor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDistributor.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvDistributor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistributor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvDistributor.Location = new System.Drawing.Point(12, 275);
            this.dgvDistributor.Name = "dgvDistributor";
            this.dgvDistributor.ReadOnly = true;
            this.dgvDistributor.Size = new System.Drawing.Size(459, 392);
            this.dgvDistributor.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 67;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Distributor Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 132;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Brand Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 109;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Distributor Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 138;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "GST No";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 82;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Contact Name";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 119;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Contact No";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 101;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Company Address";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 141;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "State";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 69;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "City";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 62;
            // 
            // grpDist
            // 
            this.grpDist.Controls.Add(this.label7);
            this.grpDist.Controls.Add(this.txtCit);
            this.grpDist.Controls.Add(this.txtContNo);
            this.grpDist.Controls.Add(this.txtCompAddress);
            this.grpDist.Controls.Add(this.txtContName);
            this.grpDist.Controls.Add(this.txtCompGST);
            this.grpDist.Controls.Add(this.txtDistName);
            this.grpDist.Controls.Add(this.cmbState);
            this.grpDist.Controls.Add(this.label6);
            this.grpDist.Controls.Add(this.label5);
            this.grpDist.Controls.Add(this.label4);
            this.grpDist.Controls.Add(this.label3);
            this.grpDist.Controls.Add(this.label2);
            this.grpDist.Controls.Add(this.label1);
            this.grpDist.Controls.Add(this.label37);
            this.grpDist.Controls.Add(this.cmbbrand);
            this.grpDist.Controls.Add(this.rbtnUR);
            this.grpDist.Controls.Add(this.rbtnR);
            this.grpDist.Location = new System.Drawing.Point(549, 104);
            this.grpDist.Name = "grpDist";
            this.grpDist.Size = new System.Drawing.Size(703, 273);
            this.grpDist.TabIndex = 4;
            this.grpDist.TabStop = false;
            this.grpDist.Text = "Add Distributor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Brand Name";
            // 
            // txtCit
            // 
            this.txtCit.Location = new System.Drawing.Point(506, 198);
            this.txtCit.Name = "txtCit";
            this.txtCit.Size = new System.Drawing.Size(191, 26);
            this.txtCit.TabIndex = 27;
            // 
            // txtContNo
            // 
            this.txtContNo.Location = new System.Drawing.Point(506, 124);
            this.txtContNo.Name = "txtContNo";
            this.txtContNo.Size = new System.Drawing.Size(191, 26);
            this.txtContNo.TabIndex = 26;
            // 
            // txtCompAddress
            // 
            this.txtCompAddress.Location = new System.Drawing.Point(183, 195);
            this.txtCompAddress.Name = "txtCompAddress";
            this.txtCompAddress.Size = new System.Drawing.Size(191, 26);
            this.txtCompAddress.TabIndex = 25;
            // 
            // txtContName
            // 
            this.txtContName.Location = new System.Drawing.Point(183, 150);
            this.txtContName.Name = "txtContName";
            this.txtContName.Size = new System.Drawing.Size(191, 26);
            this.txtContName.TabIndex = 24;
            // 
            // txtCompGST
            // 
            this.txtCompGST.Location = new System.Drawing.Point(183, 106);
            this.txtCompGST.Name = "txtCompGST";
            this.txtCompGST.Size = new System.Drawing.Size(191, 26);
            this.txtCompGST.TabIndex = 23;
            // 
            // txtDistName
            // 
            this.txtDistName.Location = new System.Drawing.Point(183, 60);
            this.txtDistName.Name = "txtDistName";
            this.txtDistName.Size = new System.Drawing.Size(191, 26);
            this.txtDistName.TabIndex = 22;
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(183, 233);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(191, 27);
            this.cmbState.TabIndex = 21;
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Contact No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "State Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Company Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Contact Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Company GST No";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(17, 70);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(126, 19);
            this.label37.TabIndex = 14;
            this.label37.Text = "Distributor Name";
            // 
            // cmbbrand
            // 
            this.cmbbrand.FormattingEnabled = true;
            this.cmbbrand.Location = new System.Drawing.Point(492, 28);
            this.cmbbrand.Name = "cmbbrand";
            this.cmbbrand.Size = new System.Drawing.Size(191, 27);
            this.cmbbrand.TabIndex = 13;
            this.cmbbrand.SelectedIndexChanged += new System.EventHandler(this.cmbbrand_SelectedIndexChanged);
            // 
            // rbtnUR
            // 
            this.rbtnUR.AutoSize = true;
            this.rbtnUR.Location = new System.Drawing.Point(183, 32);
            this.rbtnUR.Name = "rbtnUR";
            this.rbtnUR.Size = new System.Drawing.Size(120, 23);
            this.rbtnUR.TabIndex = 12;
            this.rbtnUR.TabStop = true;
            this.rbtnUR.Text = "UnRegistered";
            this.rbtnUR.UseVisualStyleBackColor = true;
            // 
            // rbtnR
            // 
            this.rbtnR.AutoSize = true;
            this.rbtnR.Location = new System.Drawing.Point(35, 32);
            this.rbtnR.Name = "rbtnR";
            this.rbtnR.Size = new System.Drawing.Size(101, 23);
            this.rbtnR.TabIndex = 11;
            this.rbtnR.TabStop = true;
            this.rbtnR.Text = "Registered";
            this.rbtnR.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAccoNo);
            this.groupBox2.Controls.Add(this.txtbMICR);
            this.groupBox2.Controls.Add(this.txtbIFSC);
            this.groupBox2.Controls.Add(this.txtbankname);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(549, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 234);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Bank Details";
            // 
            // txtAccoNo
            // 
            this.txtAccoNo.Location = new System.Drawing.Point(415, 81);
            this.txtAccoNo.Name = "txtAccoNo";
            this.txtAccoNo.Size = new System.Drawing.Size(191, 26);
            this.txtAccoNo.TabIndex = 31;
            // 
            // txtbMICR
            // 
            this.txtbMICR.Location = new System.Drawing.Point(415, 187);
            this.txtbMICR.Name = "txtbMICR";
            this.txtbMICR.Size = new System.Drawing.Size(191, 26);
            this.txtbMICR.TabIndex = 30;
            // 
            // txtbIFSC
            // 
            this.txtbIFSC.Location = new System.Drawing.Point(415, 139);
            this.txtbIFSC.Name = "txtbIFSC";
            this.txtbIFSC.Size = new System.Drawing.Size(191, 26);
            this.txtbIFSC.TabIndex = 29;
            // 
            // txtbankname
            // 
            this.txtbankname.Location = new System.Drawing.Point(415, 25);
            this.txtbankname.Name = "txtbankname";
            this.txtbankname.Size = new System.Drawing.Size(191, 26);
            this.txtbankname.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(248, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 19);
            this.label11.TabIndex = 18;
            this.label11.Text = "IFSC Code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(248, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "MICR Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Account No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Add Bank Name";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "hh:mm:ssss";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(1113, 60);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(96, 26);
            this.dtpTime.TabIndex = 9;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(1113, 36);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(96, 26);
            this.dtpDate.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pooranyash_SmartPhone.Properties.Resources.caltime;
            this.pictureBox2.Location = new System.Drawing.Point(995, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pooranyash_SmartPhone.Properties.Resources.dailyexpenses;
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::Pooranyash_SmartPhone.Properties.Resources.SaveBtn;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1041, 624);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::Pooranyash_SmartPhone.Properties.Resources.browse1;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(365, 197);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(296, 140);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(191, 27);
            this.cmbSearch.TabIndex = 22;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::Pooranyash_SmartPhone.Properties.Resources.ExitBtn;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1156, 624);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 28);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDistributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpDist);
            this.Controls.Add(this.dgvDistributor);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDistributor";
            this.Text = "frmDistributor";
            this.Load += new System.EventHandler(this.frmDistributor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistributor)).EndInit();
            this.grpDist.ResumeLayout(false);
            this.grpDist.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvDistributor;
        private System.Windows.Forms.GroupBox grpDist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RadioButton rbtnR;
        private System.Windows.Forms.RadioButton rbtnUR;
        private System.Windows.Forms.ComboBox cmbbrand;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCit;
        private System.Windows.Forms.TextBox txtContNo;
        private System.Windows.Forms.TextBox txtCompAddress;
        private System.Windows.Forms.TextBox txtContName;
        private System.Windows.Forms.TextBox txtCompGST;
        private System.Windows.Forms.TextBox txtDistName;
        private System.Windows.Forms.TextBox txtAccoNo;
        private System.Windows.Forms.TextBox txtbMICR;
        private System.Windows.Forms.TextBox txtbIFSC;
        private System.Windows.Forms.TextBox txtbankname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnExit;
    }
}