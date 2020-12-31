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
    public partial class frmSale : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        SqlDataReader dr;
        public frmSale()
        {
            InitializeComponent();
            con.Open();
            fetchProduct();
            fetchIMEI1();
            fetchIMEI2();
            fetchGST();
        }

        private void txtInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtInvoice.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Bank Account Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtInvoice.Focus();
                }
                else
                {
                    txtCustomerName.Focus();
                }
            }
        }

        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCustomerName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Bank Account Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCustomerName.Focus();
                }
                else
                {
                    cmbProductName.Focus();
                }
            }
        }

        private void cmbProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbProductName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Bank Account Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbProductName.Focus();
                }
                else
                {
                    cmbIMEI1.Focus();
                }
            }
        }

        private void cmbIMEI1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbIMEI1.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Bank Account Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbIMEI1.Focus();
                }
                else
                {
                    cmbIMEI2.Focus();
                }
            }
        }

        private void cmbIMEI2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbIMEI2.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Bank Account Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbIMEI2.Focus();
                }
                else
                {
                    txtSale.Focus();
                }
            }
        }

        private void txtSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSale.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Bank Account Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSale.Focus();
                }
                else
                {
                    cmbGSTRate.Focus();
                }
            }
        }

        private void cmbGSTRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbGSTRate.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Bank Account Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbGSTRate.Focus();
                }
                else
                {
                    txtQuantity.Focus();
                }
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtQuantity.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Bank Account Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQuantity.Focus();
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
                    MessageBox.Show("Enter your Bank Account Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Focus();
                }
                else
                {
                    btnSave.Focus();
                }
            }
        }
        void fetchProduct()
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchProduct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbProductName.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string Productid;
        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchProductID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@ProductName", SqlDbType.VarChar);
            p1.Value = cmbProductName.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                Productid = dr[0].ToString();

            }
            dr.Close();
        }

        void fetchIMEI1()
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchIMEI", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbIMEI1.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string imei1;
        private void cmbIMEI1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchIMEIID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@IMEI1", SqlDbType.BigInt);
            p1.Value = cmbIMEI1.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                imei1 = dr[0].ToString();

            }
            dr.Close();
        }

        void fetchIMEI2()
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchIMEI2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbIMEI2.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string imei2;

        private void cmbIMEI2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchIMEIID2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@IMEI2", SqlDbType.BigInt);
            p1.Value = cmbIMEI2.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                imei2 = dr[0].ToString();

            }
            dr.Close();
        }

        void fetchGST()
        {
            SqlCommand cmd = new SqlCommand("Pro_GSTFetch", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbGSTRate.Items.Add(dr[0]);

            }

            dr.Close();
        }
        string gstidd;

        private void cmbGSTRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchIDGST", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@GST", SqlDbType.BigInt);
            p1.Value = cmbGSTRate.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                gstidd = dr[0].ToString();

            }
            dr.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_InsertSale", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@InvoiceNo", SqlDbType.BigInt);
                p1.Value = txtInvoice.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@CustomerName", SqlDbType.NVarChar);
                p1.Value = txtCustomerName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ContactNo", SqlDbType.BigInt);
                p1.Value = txtContactNo.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ProductName", SqlDbType.NVarChar);
                p1.Value = cmbProductName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@IMEI1", SqlDbType.BigInt);
                p1.Value = cmbIMEI1.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@IMEI2", SqlDbType.BigInt);
                p1.Value = cmbIMEI2.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Sale", SqlDbType.BigInt);
                p1.Value = txtSale.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@GST", SqlDbType.BigInt);
                p1.Value = cmbGSTRate.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Quantity", SqlDbType.BigInt);
                p1.Value = txtQuantity.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Amount", SqlDbType.BigInt);
                p1.Value = txtAmount.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@TotalAmount", SqlDbType.BigInt);
                p1.Value = txtTotalAmount.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@SaleTransactionId", SqlDbType.Int);
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

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Trim() == "")
            {
            }
            else
            {
                txtAmount.Text = (float.Parse(txtQuantity.Text) * float.Parse(txtSale.Text)).ToString();
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text.Trim() == "")
            {
            }
            else
            {
                txtTotalAmount.Text = ((float.Parse(txtAmount.Text))+float.Parse(txtAmount.Text) * float.Parse(cmbGSTRate.Text)/100).ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSale_Load(object sender, EventArgs e)
        {

        }


    }
}
