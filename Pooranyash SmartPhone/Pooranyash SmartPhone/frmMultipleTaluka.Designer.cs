namespace Pooranyash_SmartPhone
{
    partial class frmMultipleTaluka
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
            this.cmbDistrictName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTalukaSave = new System.Windows.Forms.Button();
            this.txtTaluka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbDistrictName
            // 
            this.cmbDistrictName.FormattingEnabled = true;
            this.cmbDistrictName.Location = new System.Drawing.Point(548, 80);
            this.cmbDistrictName.Name = "cmbDistrictName";
            this.cmbDistrictName.Size = new System.Drawing.Size(216, 27);
            this.cmbDistrictName.TabIndex = 13;
            this.cmbDistrictName.SelectedIndexChanged += new System.EventHandler(this.cmbDistrictName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select District";
            // 
            // btnTalukaSave
            // 
            this.btnTalukaSave.FlatAppearance.BorderSize = 0;
            this.btnTalukaSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTalukaSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTalukaSave.Location = new System.Drawing.Point(531, 294);
            this.btnTalukaSave.Name = "btnTalukaSave";
            this.btnTalukaSave.Size = new System.Drawing.Size(75, 23);
            this.btnTalukaSave.TabIndex = 11;
            this.btnTalukaSave.Text = "Save";
            this.btnTalukaSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTalukaSave.UseVisualStyleBackColor = true;
            this.btnTalukaSave.Click += new System.EventHandler(this.btnTalukaSave_Click);
            // 
            // txtTaluka
            // 
            this.txtTaluka.Location = new System.Drawing.Point(548, 176);
            this.txtTaluka.Name = "txtTaluka";
            this.txtTaluka.Size = new System.Drawing.Size(216, 26);
            this.txtTaluka.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Taluka";
            // 
            // frmMultipleTaluka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 381);
            this.Controls.Add(this.cmbDistrictName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTalukaSave);
            this.Controls.Add(this.txtTaluka);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMultipleTaluka";
            this.Text = "frmMultipleTaluka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDistrictName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTalukaSave;
        private System.Windows.Forms.TextBox txtTaluka;
        private System.Windows.Forms.Label label1;
    }
}