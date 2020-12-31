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
    public partial class frmFirmRegistration : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        SqlDataReader dr;

        void clear()
        {
            txtFName.Text = "";
            txtFAddress.Text = "";
            cmbState.Text = "";
            txtCity.Text = "";
            txtPin.Text = "";
            txtGST.Text = "";
            txtOwner.Text = "";
            txtMobile.Text = "";
            txtPan.Text = "";
            txtMail.Text = "";
            txtFirmPic.Text = "";
            
        }

        public frmFirmRegistration()
        {
            InitializeComponent();
            con.Open();
            fetchState();
            filldata();
        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtFName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtFName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Name", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFName.Focus();
                }
                else
                {
                    txtFAddress.Focus();
                }
            }
        }

        private void txtFAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtFAddress.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Address", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFAddress.Focus();
                }
                else
                {
                    cmbState.Focus();
                }
            }
        }

        private void cmbState_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbState.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your State", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbState.Focus();
                }
                else
                {
                    txtCity.Focus();
                }
            }
        }

        private void txtCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCity.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your City", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCity.Focus();
                }
                else
                {
                    txtPin.Focus();
                }
            }
        }

        private void txtPin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPin.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Pin", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPin.Focus();
                }
                else
                {
                    txtGST.Focus();
                }
            }
        }

        private void txtGST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtGST.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your GST No", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGST.Focus();
                }
                else
                {
                    txtOwner.Focus();
                }
            }
        }

        private void txtOwner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtOwner.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Owner Name", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOwner.Focus();
                }
                else
                {
                    txtMobile.Focus();
                }
            }
        }

        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMobile.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Mobile No", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMobile.Focus();
                }
                else
                {
                    txtPan.Focus();
                }
            }
        }

        private void txtPan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPan.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Pan No", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPan.Focus();
                }
                else
                {
                    txtMail.Focus();
                }
            }
        }

        private void txtMail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMail.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Mail", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMail.Focus();
                }
                else
                {
                    btnSave.Focus();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.Copy(txtFirmPic.Text, Path.Combine(@"F:\PooraYash Infotech\Pooranyash SmartPhone\Pooranyash SmartPhone\FirmPic", Path.GetFileName(txtFirmPic.Text)), true);

            try
            {
                SqlCommand cmd = new SqlCommand("Pro_StateInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@FName", SqlDbType.NVarChar);
                p1.Value = txtFName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@FAddress", SqlDbType.NVarChar);
                p1.Value = txtFAddress.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@FState", SqlDbType.NVarChar);
                p1.Value = cmbState.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@FCity", SqlDbType.NVarChar);
                p1.Value = txtCity.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@FPin", SqlDbType.BigInt);
                p1.Value = txtPin.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@FGSTNo", SqlDbType.NVarChar);
                p1.Value = txtGST.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@FOwnerName", SqlDbType.NVarChar);
                p1.Value = txtOwner.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@FMobile", SqlDbType.BigInt);
                p1.Value = txtMobile.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@FPAN", SqlDbType.NVarChar);
                p1.Value = txtPan.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@FMail", SqlDbType.NVarChar);
                p1.Value = txtMail.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Firm", SqlDbType.NVarChar);
                p1.Value = txtFirmPic.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@FirmTransactionId", SqlDbType.Int);
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
                    filldata();
                    clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Save Button" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int i;
        void filldata()
        {
            try
            {
                dgvFirm.Rows.Clear();
                SqlCommand cmd = new SqlCommand("select FirmId,FOwnerName,FName,FGSTNo from tblFirm", con);
                dr = cmd.ExecuteReader();
                i = 0;
                while (dr.Read())
                {
                    dgvFirm.Rows.Add();
                    dgvFirm.Rows[i].Cells[0].Value = dr[0];
                    dgvFirm.Rows[i].Cells[1].Value = dr[1];
                    dgvFirm.Rows[i].Cells[2].Value = dr[2];
                    dgvFirm.Rows[i].Cells[3].Value = dr[3];

                    i++;

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "System says", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void fetchState()
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchState", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbState.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string stateid;

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchStateID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@StateName", SqlDbType.VarChar);
            p1.Value = cmbState.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                stateid = dr[0].ToString();

            }
            dr.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();                                                  // open file dialog  

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";       // image filters  
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbFirm.Image = new Bitmap(open.FileName);                                               // display image in picture box  
                txtFirmPic.Text = open.FileName;                                                        // image file path  
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
