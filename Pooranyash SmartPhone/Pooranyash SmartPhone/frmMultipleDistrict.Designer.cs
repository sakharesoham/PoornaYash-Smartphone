namespace Pooranyash_SmartPhone
{
    partial class frmMultipleDistrict
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
            this.btnDistrictSave = new System.Windows.Forms.Button();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStateName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDistrictSave
            // 
            this.btnDistrictSave.FlatAppearance.BorderSize = 0;
            this.btnDistrictSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistrictSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDistrictSave.Location = new System.Drawing.Point(396, 309);
            this.btnDistrictSave.Name = "btnDistrictSave";
            this.btnDistrictSave.Size = new System.Drawing.Size(75, 23);
            this.btnDistrictSave.TabIndex = 6;
            this.btnDistrictSave.Text = "Save";
            this.btnDistrictSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDistrictSave.UseVisualStyleBackColor = true;
            this.btnDistrictSave.Click += new System.EventHandler(this.btnDistrictSave_Click);
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(352, 190);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(216, 26);
            this.txtDistrict.TabIndex = 5;
            this.txtDistrict.TextChanged += new System.EventHandler(this.txtState_TextChanged);
            this.txtDistrict.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDistrict_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select State";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select District";
            // 
            // cmbStateName
            // 
            this.cmbStateName.FormattingEnabled = true;
            this.cmbStateName.Location = new System.Drawing.Point(352, 94);
            this.cmbStateName.Name = "cmbStateName";
            this.cmbStateName.Size = new System.Drawing.Size(216, 27);
            this.cmbStateName.TabIndex = 8;
            this.cmbStateName.SelectedIndexChanged += new System.EventHandler(this.cmbStateName_SelectedIndexChanged);
            // 
            // frmMultipleDistrict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 405);
            this.Controls.Add(this.cmbStateName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDistrictSave);
            this.Controls.Add(this.txtDistrict);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMultipleDistrict";
            this.Text = "frmMultipleDistrict";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDistrictSave;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStateName;
    }
}