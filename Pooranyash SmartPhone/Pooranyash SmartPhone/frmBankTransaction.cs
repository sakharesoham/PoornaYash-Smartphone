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
    public partial class frmBankTransaction : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        SqlDataReader dr;

        public frmBankTransaction()
        {
            InitializeComponent();
            con.Open();
            fetchAccount();
            fetchType();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbBankAccNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbBankAccNo.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Invoice Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbBankAccNo.Focus();
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
                    MessageBox.Show("Enter your Invoice Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBankName.Focus();
                }
                else
                {
                    txtBalance.Focus();
                }
            }
        }

        private void txtBalance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBalance.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Invoice Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBalance.Focus();
                }
                else
                {
                    cmbDeposit.Focus();
                }
            }
        }

        private void cmbDeposit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbDeposit.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Invoice Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbDeposit.Focus();
                }
                else
                {
                    txtAmount.Focus();
                }
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAmount.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Invoice Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Focus();
                }
                else
                {
                    txtNarration.Focus();
                }
            }
        }

        private void txtNarration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNarration.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Invoice Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNarration.Focus();
                }
                else
                {
                    btnSave.Focus();
                }
            }
        }

        void fetchAccount()
        {
            SqlCommand cmd = new SqlCommand("Pro_fetchBank", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbBankAccNo.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string bankid;

        private void cmbBankAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchBankID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@BankAccountNo", SqlDbType.VarChar);
            p1.Value = cmbBankAccNo.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                bankid = dr[0].ToString();

            }
            dr.Close();
        }

        void fetchType()
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchDeposit", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbDeposit.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string typeid;

        private void cmbDeposit_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchDepositID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@Deposit", SqlDbType.VarChar);
            p1.Value = cmbDeposit.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                typeid = dr[0].ToString();

            }
            dr.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_BankInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@BankAccNo", SqlDbType.BigInt);
                p1.Value = cmbBankAccNo.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@BankName", SqlDbType.NVarChar);
                p1.Value = txtBankName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Balance", SqlDbType.BigInt);
                p1.Value = txtBalance.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Deposit", SqlDbType.NVarChar);
                p1.Value = cmbDeposit.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Amount", SqlDbType.BigInt);
                p1.Value = txtAmount.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Narration", SqlDbType.NVarChar);
                p1.Value = txtNarration.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@TransactionId", SqlDbType.Int);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBankTransaction_Load(object sender, EventArgs e)
        {

        }

    }
}
