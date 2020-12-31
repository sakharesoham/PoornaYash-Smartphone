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
    public partial class frmRechargeCompanyMaster : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        SqlDataReader dr;

        void clear()
        {
            txtRechargeCompanyName.Text = "";
        }

        public frmRechargeCompanyMaster()
        {
            InitializeComponent();
            con.Open();
            filldata();
        }

        private void txtRechargeCompanyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtRechargeCompanyName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Company Name", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRechargeCompanyName.Focus();
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
                SqlCommand cmd = new SqlCommand("Pro_InsertRecharge", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@RechargeCompany", SqlDbType.NVarChar);
                p1.Value = txtRechargeCompanyName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@RechargeTransactionId", SqlDbType.Int);
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
                dgvRecharge.Rows.Clear();
                SqlCommand cmd = new SqlCommand("select * from Recharge", con);

                dr = cmd.ExecuteReader();
                i = 0;
                while (dr.Read())
                {
                    dgvRecharge.Rows.Add();
                    dgvRecharge.Rows[i].Cells[0].Value = dr[0];
                    dgvRecharge.Rows[i].Cells[1].Value = dr[1];
                  
                    i++;

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "System says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string rechargeid;
        private void dgvRecharge_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            rechargeid = dgvRecharge.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtRechargeCompanyName.Text = dgvRecharge.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_InsertRecharge", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@RechargeID", SqlDbType.NVarChar);
                p1.Value = rechargeid;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@RechargeCompany", SqlDbType.NVarChar);
                p1.Value = txtRechargeCompanyName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@RechargeTransactionId", SqlDbType.Int);
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

       
    }
}
