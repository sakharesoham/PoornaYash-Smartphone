namespace Pooranyash_SmartPhone
{
    partial class frmMultipleState
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnStateSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select State";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(148, 162);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 26);
            this.txtState.TabIndex = 2;
            this.txtState.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtState_KeyDown);
            // 
            // btnStateSave
            // 
            this.btnStateSave.FlatAppearance.BorderSize = 0;
            this.btnStateSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStateSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStateSave.Location = new System.Drawing.Point(163, 246);
            this.btnStateSave.Name = "btnStateSave";
            this.btnStateSave.Size = new System.Drawing.Size(75, 23);
            this.btnStateSave.TabIndex = 3;
            this.btnStateSave.Text = "Save";
            this.btnStateSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStateSave.UseVisualStyleBackColor = true;
            this.btnStateSave.Click += new System.EventHandler(this.btnStateSave_Click);
            // 
            // frmMultipleState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 381);
            this.Controls.Add(this.btnStateSave);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMultipleState";
            this.Text = "frmMultipleState";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button btnStateSave;
    }
}