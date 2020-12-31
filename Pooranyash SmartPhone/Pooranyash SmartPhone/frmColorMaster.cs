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
    public partial class frmColorMaster : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        SqlDataReader dr;
        public frmColorMaster()
        {
            InitializeComponent();
            con.Open();
            filldata();
        }

        private void frmColorMaster_Load(object sender, EventArgs e)
        {

        }

        private void txtColorName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtColorName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your ColorName", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtColorName.Focus();
                }
                else
                {
                    btnSave.Focus();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_InsertUpdateColor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@ColorName", SqlDbType.NVarChar);
                p1.Value = txtColorName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ColorTransactionId", SqlDbType.Int);
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
                dgvColor.Rows.Clear();
                SqlCommand cmd = new SqlCommand("select * from tblColor", con);

                dr = cmd.ExecuteReader();
                i = 0;
                while (dr.Read())
                {
                    dgvColor.Rows.Add();
                    dgvColor.Rows[i].Cells[0].Value = dr[0];
                    dgvColor.Rows[i].Cells[1].Value = dr[1];




                    i++;

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "System says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string colorgridid;
        private void dgvColor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            colorgridid = dgvColor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtColorName.Text = dgvColor.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_InsertUpdateColor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@ColorID", SqlDbType.NVarChar);
                p1.Value = colorgridid;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ColorName", SqlDbType.NVarChar);
                p1.Value = txtColorName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ColorTransactionId", SqlDbType.Int);
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
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Save Button" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
