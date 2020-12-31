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
    public partial class frmBank_Master : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        SqlDataReader dr;

        void clear()
        { 
        txtBankAccNumber.Text="";
        txtAccHolderName.Text = "";
        txtBankName.Text = "";
        txtBankAddress.Text = "";
        txtOpeningBalance.Text = "";
        txtIFSC.Text = "";
        txtMICR.Text = "";
        }

        public frmBank_Master()
        {
            InitializeComponent();
            con.Open();
            filldata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBankAccNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBankAccNumber.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Bank Account Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBankAccNumber.Focus();
                }
                else
                {
                    txtAccHolderName.Focus();
                }
            }
        }

        private void txtAccHolderName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAccHolderName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Account Holder's Name", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAccHolderName.Focus();
                }
                else
                {
                    txtBankName.Focus();
                }
            }
        }

        private void txtBankName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBankName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Name of your Bank", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBankName.Focus();
                }
                else
                {
                    txtBankAddress.Focus();
                }
            }
        }

        private void txtBankAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBankAddress.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Bank Address", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBankAddress.Focus();
                }
                else
                {
                    txtOpeningBalance.Focus();
                }
            }
        }

        private void txtOpeningBalance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtOpeningBalance.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Opening Balance", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOpeningBalance.Focus();
                }
                else
                {
                    txtIFSC.Focus();
                }
            }
        }

        private void txtIFSC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtIFSC.Text.Trim() == "")
                {
                    MessageBox.Show("Enter IFSC Code of Bank", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIFSC.Focus();
                }
                else
                {
                    txtMICR.Focus();
                }
            }
        }

        private void txtMICR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMICR.Text.Trim() == "")
                {
                    MessageBox.Show("Enter MICR Code", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMICR.Focus();
                }
                else
                {
                    btnSave.Focus();
                }
            }
        }

        int i;
        void filldata()
        {
            try
            {
                dgvBank.Rows.Clear();
                SqlCommand cmd = new SqlCommand("select * from tblBank", con);

                dr = cmd.ExecuteReader();
                i = 0;
                while (dr.Read())
                {
                    dgvBank.Rows.Add();
                    dgvBank.Rows[i].Cells[0].Value = dr[0];
                    dgvBank.Rows[i].Cells[1].Value = dr[1];
                    dgvBank.Rows[i].Cells[2].Value = dr[2];
                    dgvBank.Rows[i].Cells[3].Value = dr[3];
                    dgvBank.Rows[i].Cells[4].Value = dr[4];
                    dgvBank.Rows[i].Cells[5].Value = dr[5];
                    dgvBank.Rows[i].Cells[6].Value = dr[6];
                    dgvBank.Rows[i].Cells[7].Value = dr[7];



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
                SqlCommand cmd = new SqlCommand("Pro_insertupdateBank", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@BankAccountNo", SqlDbType.BigInt);
                p1.Value = txtBankAccNumber.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@AccountHolderName", SqlDbType.NVarChar);
                p1.Value = txtAccHolderName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@BankName", SqlDbType.NVarChar);
                p1.Value = txtBankName.Text;
                cmd.Parameters.Add(p1);


                p1 = new SqlParameter("@BranchAddress", SqlDbType.NVarChar);
                p1.Value = txtBankAddress.Text;
                cmd.Parameters.Add(p1);


                p1 = new SqlParameter("@OpeningBalance", SqlDbType.BigInt);
                p1.Value = txtOpeningBalance.Text;
                cmd.Parameters.Add(p1);


                p1 = new SqlParameter("@IFSC", SqlDbType.NVarChar);
                p1.Value = txtIFSC.Text;
                cmd.Parameters.Add(p1);


                p1 = new SqlParameter("@MICR", SqlDbType.BigInt);
                p1.Value = txtMICR.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@BankTransactionId", SqlDbType.Int);
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
        string bankid;
        private void dgvBank_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            bankid = dgvBank.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBankAccNumber.Text = dgvBank.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAccHolderName.Text = dgvBank.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtBankName.Text = dgvBank.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtBankAddress.Text = dgvBank.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtOpeningBalance.Text = dgvBank.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtIFSC.Text = dgvBank.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtMICR.Text = dgvBank.Rows[e.RowIndex].Cells[7].Value.ToString();
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_insertupdateBank", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@BankID", SqlDbType.BigInt);
                p1.Value = bankid;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@BankAccountNo", SqlDbType.BigInt);
                p1.Value = txtBankAccNumber.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@AccountHolderName", SqlDbType.NVarChar);
                p1.Value = txtAccHolderName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@BankName", SqlDbType.NVarChar);
                p1.Value = txtBankName.Text;
                cmd.Parameters.Add(p1);


                p1 = new SqlParameter("@BranchAddress", SqlDbType.NVarChar);
                p1.Value = txtBankAddress.Text;
                cmd.Parameters.Add(p1);


                p1 = new SqlParameter("@OpeningBalance", SqlDbType.BigInt);
                p1.Value = txtOpeningBalance.Text;
                cmd.Parameters.Add(p1);


                p1 = new SqlParameter("@IFSC", SqlDbType.NVarChar);
                p1.Value = txtIFSC.Text;
                cmd.Parameters.Add(p1);


                p1 = new SqlParameter("@MICR", SqlDbType.BigInt);
                p1.Value = txtMICR.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@BankTransactionId", SqlDbType.Int);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
