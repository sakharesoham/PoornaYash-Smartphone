namespace Pooranyash_SmartPhone
{
    partial class frmGST_Master
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
            this.lblBrandName = new System.Windows.Forms.Label();
            this.txtGSTRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSGSTRate = new System.Windows.Forms.TextBox();
            this.lblCGSTRate = new System.Windows.Forms.Label();
            this.txtCGSTRate = new System.Windows.Forms.TextBox();
            this.dgvGST = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Location = new System.Drawing.Point(308, 50);
            this.lblBrandName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(77, 19);
            this.lblBrandName.TabIndex = 26;
            this.lblBrandName.Text = "GST Rate";
            // 
            // txtGSTRate
            // 
            this.txtGSTRate.Location = new System.Drawing.Point(417, 43);
            this.txtGSTRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtGSTRate.Name = "txtGSTRate";
            this.txtGSTRate.Size = new System.Drawing.Size(184, 26);
            this.txtGSTRate.TabIndex = 0;
            this.txtGSTRate.TextChanged += new System.EventHandler(this.txtGSTRate_TextChanged);
            this.txtGSTRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGSTRate_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "SGST Rate";
            // 
            // txtSGSTRate
            // 
            this.txtSGSTRate.Location = new System.Drawing.Point(417, 99);
            this.txtSGSTRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtSGSTRate.Name = "txtSGSTRate";
            this.txtSGSTRate.Size = new System.Drawing.Size(184, 26);
            this.txtSGSTRate.TabIndex = 1;
            this.txtSGSTRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSGSTRate_KeyDown);
            // 
            // lblCGSTRate
            // 
            this.lblCGSTRate.AutoSize = true;
            this.lblCGSTRate.Location = new System.Drawing.Point(308, 136);
            this.lblCGSTRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCGSTRate.Name = "lblCGSTRate";
            this.lblCGSTRate.Size = new System.Drawing.Size(88, 19);
            this.lblCGSTRate.TabIndex = 30;
            this.lblCGSTRate.Text = "CGST Rate";
            // 
            // txtCGSTRate
            // 
            this.txtCGSTRate.Location = new System.Drawing.Point(417, 133);
            this.txtCGSTRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtCGSTRate.Name = "txtCGSTRate";
            this.txtCGSTRate.Size = new System.Drawing.Size(184, 26);
            this.txtCGSTRate.TabIndex = 2;
            this.txtCGSTRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCGSTRate_KeyDown);
            // 
            // dgvGST
            // 
            this.dgvGST.AllowUserToAddRows = false;
            this.dgvGST.AllowUserToDeleteRows = false;
            this.dgvGST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGST.BackgroundColor = System.Drawing.Color.White;
            this.dgvGST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGST.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvGST.Location = new System.Drawing.Point(30, 248);
            this.dgvGST.Name = "dgvGST";
            this.dgvGST.ReadOnly = true;
            this.dgvGST.Size = new System.Drawing.Size(571, 225);
            this.dgvGST.TabIndex = 31;
            this.dgvGST.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGST_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "GST ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "GST Rate";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SGST Rate";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CGST Rate";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 31);
            this.label2.TabIndex = 33;
            this.label2.Text = "GST Master";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Image = global::Pooranyash_SmartPhone.Properties.Resources.UpdateBtn;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(380, 168);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 45);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::Pooranyash_SmartPhone.Properties.Resources.ExitBtn;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(515, 168);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::Pooranyash_SmartPhone.Properties.Resources.SaveBtn;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(272, 168);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 45);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pooranyash_SmartPhone.Properties.Resources.gst;
            this.pictureBox1.Location = new System.Drawing.Point(30, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // frmGST_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvGST);
            this.Controls.Add(this.lblCGSTRate);
            this.Controls.Add(this.txtCGSTRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSGSTRate);
            this.Controls.Add(this.lblBrandName);
            this.Controls.Add(this.txtGSTRate);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGST_Master";
            this.Text = "o";
            this.Load += new System.EventHandler(this.frmGST_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.TextBox txtGSTRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSGSTRate;
        private System.Windows.Forms.Label lblCGSTRate;
        private System.Windows.Forms.TextBox txtCGSTRate;
        private System.Windows.Forms.DataGridView dgvGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}