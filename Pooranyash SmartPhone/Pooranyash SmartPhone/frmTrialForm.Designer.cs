namespace Pooranyash_SmartPhone
{
    partial class frmTrialForm
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
            this.btnID = new System.Windows.Forms.Button();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbIDProof = new System.Windows.Forms.PictureBox();
            this.pbPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIDProof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnID
            // 
            this.btnID.BackColor = System.Drawing.Color.Azure;
            this.btnID.FlatAppearance.BorderSize = 0;
            this.btnID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnID.Location = new System.Drawing.Point(165, 192);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(102, 34);
            this.btnID.TabIndex = 0;
            this.btnID.Text = "Upload ID";
            this.btnID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnID.UseVisualStyleBackColor = false;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackColor = System.Drawing.Color.Azure;
            this.btnPhoto.FlatAppearance.BorderSize = 0;
            this.btnPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhoto.Location = new System.Drawing.Point(410, 192);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(108, 34);
            this.btnPhoto.TabIndex = 1;
            this.btnPhoto.Text = "Upload Photo";
            this.btnPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPhoto.UseVisualStyleBackColor = false;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // txtPhoto
            // 
            this.txtPhoto.Location = new System.Drawing.Point(398, 135);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(131, 26);
            this.txtPhoto.TabIndex = 37;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(151, 135);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(131, 26);
            this.txtID.TabIndex = 38;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::Pooranyash_SmartPhone.Properties.Resources.SaveBtn;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(279, 242);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 35);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbIDProof
            // 
            this.pbIDProof.Location = new System.Drawing.Point(142, 106);
            this.pbIDProof.Name = "pbIDProof";
            this.pbIDProof.Size = new System.Drawing.Size(149, 80);
            this.pbIDProof.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIDProof.TabIndex = 40;
            this.pbIDProof.TabStop = false;
            // 
            // pbPic
            // 
            this.pbPic.Location = new System.Drawing.Point(375, 106);
            this.pbPic.Name = "pbPic";
            this.pbPic.Size = new System.Drawing.Size(169, 80);
            this.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPic.TabIndex = 41;
            this.pbPic.TabStop = false;
            // 
            // frmTrialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 353);
            this.Controls.Add(this.pbPic);
            this.Controls.Add(this.pbIDProof);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPhoto);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.btnID);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTrialForm";
            this.Text = "frmTrialForm";
            this.Load += new System.EventHandler(this.frmTrialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIDProof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.TextBox txtPhoto;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbIDProof;
        private System.Windows.Forms.PictureBox pbPic;
    }
}