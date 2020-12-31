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
    public partial class frmSupplierRegistration : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        SqlDataReader dr;

        void clear()
        {
            txtSupplierName.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtAltContact.Text = "";
            txtGSTIN.Text = "";
            txtBankAccNo.Text = "";
            txtBankName.Text = "";
            txtIFSC.Text = "";
            txtMICR.Text = "";
            txtOpeningBal.Text = "";
        }

        public frmSupplierRegistration()
        {
            InitializeComponent();
            con.Open();
            filldata();
        }

        private void frmSupplierRegistration_Load(object sender, EventArgs e)
        {

        }

        private void txtSupplierName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSupplierName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your GST Rate", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSupplierName.Focus();
                }
                else
                {
                    txtAddress.Focus();
                }
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAddress.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your GST Rate", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAddress.Focus();
                }
                else
                {
                    txtContact.Focus();
                }
            }
        }

        private void txtContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtContact.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your GST Rate", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtContact.Focus();
                }
                else
                {
                    txtAltContact.Focus();
                }
            }
        }

        private void txtAltContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAltContact.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your GST Rate", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAltContact.Focus();
                }
                else
                {
                    txtGSTIN.Focus();
                }
            }
        }

        private void txtGSTIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtGSTIN.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your GST Rate", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGSTIN.Focus();
                }
                else
                {
                    txtBankAccNo.Focus();
                }
            }
        }

        private void txtBankAccNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBankAccNo.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your GST Rate", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBankAccNo.Focus();
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
                    MessageBox.Show("Enter your GST Rate", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBankName.Focus();
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
                    MessageBox.Show("Enter your GST Rate", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Enter your GST Rate", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMICR.Focus();
                }
                else
                {
                    txtOpeningBal.Focus();
                }
            }
        }

        private void txtOpeningBal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtOpeningBal.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your GST Rate", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOpeningBal.Focus();
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
                dgvSupply.Rows.Clear();
                SqlCommand cmd = new SqlCommand("select * from Supplier", con);

                dr = cmd.ExecuteReader();
                i = 0;
                while (dr.Read())
                {
                    dgvSupply.Rows.Add();
                    dgvSupply.Rows[i].Cells[0].Value = dr[0];
                    dgvSupply.Rows[i].Cells[1].Value = dr[1];
                    dgvSupply.Rows[i].Cells[2].Value = dr[2];
                    dgvSupply.Rows[i].Cells[3].Value = dr[3];
                    dgvSupply.Rows[i].Cells[4].Value = dr[4];
                    dgvSupply.Rows[i].Cells[5].Value = dr[5];
                    dgvSupply.Rows[i].Cells[6].Value = dr[6];
                    dgvSupply.Rows[i].Cells[7].Value = dr[7];
                    dgvSupply.Rows[i].Cells[8].Value = dr[8];
                    dgvSupply.Rows[i].Cells[9].Value = dr[9];
                    dgvSupply.Rows[i].Cells[10].Value = dr[10];



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
                SqlCommand cmd = new SqlCommand("Pro_InsertUpdateSupplier", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@SupplierName", SqlDbType.NVarChar);
                p1.Value = txtSupplierName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Addresss", SqlDbType.NVarChar);
                p1.Value = txtAddress.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ContactNo", SqlDbType.BigInt);
                p1.Value = txtContact.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@AltContact", SqlDbType.BigInt);
                p1.Value = txtAltContact.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@GSTIN", SqlDbType.NVarChar);
                p1.Value = txtGSTIN.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@BankAccNo", SqlDbType.BigInt);
                p1.Value = txtBankAccNo.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@BankName", SqlDbType.NVarChar);
                p1.Value = txtBankName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@IFSC", SqlDbType.NVarChar);
                p1.Value = txtIFSC.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@MICR", SqlDbType.NVarChar);
                p1.Value = txtMICR.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@OpeningBalance", SqlDbType.BigInt);
                p1.Value = txtOpeningBal.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@SupplierTransactionId", SqlDbType.Int);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
