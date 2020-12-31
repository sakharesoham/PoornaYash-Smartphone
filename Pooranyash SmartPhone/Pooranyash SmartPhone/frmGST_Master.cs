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

namespace Pooranyash_SmartPhone
{
    public partial class frmGST_Master : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        SqlDataReader dr;

        void clear()
        {
            txtGSTRate.Text = "";
            txtCGSTRate.Text = "";
            txtSGSTRate.Text = "";
        }
        void disable()
        {
            txtSGSTRate.Enabled = false;
            txtCGSTRate.Enabled = false;
        }

        public frmGST_Master()
        {
            InitializeComponent();
            con.Open();
            filldata();
        }

        private void txtGSTRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtGSTRate.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your GST Rate", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGSTRate.Focus();
                }
                else
                {
                    txtSGSTRate.Focus();
                }
            }
        }

        private void txtSGSTRate_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtCGSTRate_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtGSTRate_TextChanged(object sender, EventArgs e)
        {
            if (txtGSTRate.Text.Trim() == "")
            {
                txtSGSTRate.Text = "";
                txtCGSTRate.Text = "";
            }
            else
            {
                txtSGSTRate.Text = (float.Parse(txtGSTRate.Text) / 2).ToString();
                txtCGSTRate.Text = (float.Parse(txtGSTRate.Text) / 2).ToString();
            }
        }

        string gstid;

        private void dgvGST_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gstid = dgvGST.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtGSTRate.Text = dgvGST.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        int i;
        void filldata()
        {
            try
            {
                dgvGST.Rows.Clear();
                SqlCommand cmd = new SqlCommand("select * from tblGST", con);

                dr = cmd.ExecuteReader();
                i = 0;
                while (dr.Read())
                {
                    dgvGST.Rows.Add();
                    dgvGST.Rows[i].Cells[0].Value = dr[0];
                    dgvGST.Rows[i].Cells[1].Value = dr[1];
                    dgvGST.Rows[i].Cells[2].Value = dr[2];
                    dgvGST.Rows[i].Cells[3].Value = dr[3];



                    i++;

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "System says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_InsertUpdateGST", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@GST", SqlDbType.NVarChar);
                p1.Value = txtGSTRate.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@SGST", SqlDbType.NVarChar);
                p1.Value = txtSGSTRate.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@CGST", SqlDbType.NVarChar);
                p1.Value = txtCGSTRate.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@GSTTransactionId", SqlDbType.Int);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_InsertUpdateGST", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@GSTID", SqlDbType.NVarChar);
                p1.Value = gstid;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@GST", SqlDbType.NVarChar);
                p1.Value = txtGSTRate.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@SGST", SqlDbType.NVarChar);
                p1.Value = txtSGSTRate.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@CGST", SqlDbType.NVarChar);
                p1.Value = txtCGSTRate.Text;
                cmd.Parameters.Add(p1);


                p1 = new SqlParameter("GSTTransactionId", SqlDbType.Int);
                p1.Value = "2";
                cmd.Parameters.Add(p1);


                int n = cmd.ExecuteNonQuery();
                if (n < 0)
                {
                    MessageBox.Show("Data Not Updated!!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Updated!!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    filldata();
                    clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Save Button" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGST_Master_Load(object sender, EventArgs e)
        {
            disable();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
