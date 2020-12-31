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
    public partial class frmIMEI : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        SqlDataReader dr;
        public frmIMEI()
        {
            InitializeComponent();
            con.Open();
        }

        private void txtIMEI1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtIMEI1.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Bank Account Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIMEI1.Focus();
                }
                else
                {
                    txtIMEI2.Focus();
                }
            }
        }

        private void txtIMEI2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtIMEI2.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Bank Account Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIMEI2.Focus();
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
                SqlCommand cmd = new SqlCommand("Pro_InsertIMEI", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@IMEI1", SqlDbType.BigInt);
                p1.Value = txtIMEI1.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@IMEI2", SqlDbType.NVarChar);
                p1.Value = txtIMEI2.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@IMEITransactionId", SqlDbType.Int);
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
        string imeiid;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_InsertIMEI", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;


                p1 = new SqlParameter("@IMEI_ID", SqlDbType.BigInt);
                p1.Value = imeiid;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@IMEI1", SqlDbType.BigInt);
                p1.Value = txtIMEI1.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@IMEI2", SqlDbType.NVarChar);
                p1.Value = txtIMEI2.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@IMEITransactionId", SqlDbType.Int);
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
