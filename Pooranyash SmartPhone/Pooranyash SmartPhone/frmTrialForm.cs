using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace Pooranyash_SmartPhone
{
    public partial class frmTrialForm : Form
    {
        
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        //SqlDataReader dr;

        public frmTrialForm()
        {
            InitializeComponent();
            con.Open();
        }

        private void frmTrialForm_Load(object sender, EventArgs e)
        {

        }

        private void pbPic_Click(object sender, EventArgs e)
        {

        }

        private void btnID_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();                                                  // open file dialog  

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";       // image filters  
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbIDProof.Image = new Bitmap(open.FileName);                                               // display image in picture box  
                txtID.Text = open.FileName;                                                        // image file path  
            }
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();                                                  // open file dialog  

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";       // image filters  
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbPic.Image = new Bitmap(open.FileName);                                               // display image in picture box  
                txtPhoto.Text = open.FileName;                                                        // image file path  
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.Copy(txtID.Text, Path.Combine(@"F:\PooraYash Infotech\Pooranyash SmartPhone\Pooranyash SmartPhone\trialid", Path.GetFileName(txtID.Text)), true);
            File.Copy(txtPhoto.Text, Path.Combine(@"F:\PooraYash Infotech\Pooranyash SmartPhone\Pooranyash SmartPhone\trialpic", Path.GetFileName(txtPhoto.Text)), true);


            try
            {
                SqlCommand cmd = new SqlCommand("Pro_trialinsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@idimage", SqlDbType.NVarChar);
                p1.Value = txtID.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@picimage", SqlDbType.NVarChar);
                p1.Value = txtPhoto.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@trialtrans", SqlDbType.Int);
                p1.Value = "1";
                cmd.Parameters.Add(p1);

                int n = cmd.ExecuteNonQuery();
                if (n < 0)
                {
                    MessageBox.Show("Data Not Saved!!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Saved!!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Save Button" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
