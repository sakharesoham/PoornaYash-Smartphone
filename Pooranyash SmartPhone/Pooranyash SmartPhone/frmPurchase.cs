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
    public partial class frmPurchase : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        SqlDataReader dr;

        public frmPurchase()
        {
            InitializeComponent();
            con.Open();
            fetchProduct();
            fetchSupplier();
            fetchGST();
        }

        private void txtInvoiceNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtInvoiceNo.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Bank Account Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtInvoiceNo.Focus();
                }
                else
                {
                    cmbSupplierName.Focus();
                }
            }
        }

        private void cmbSupplierName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbSupplierName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Bank Account Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbSupplierName.Focus();
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
                    txtPurchase.Focus();
                }
            }
        }

        private void txtPurchase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPurchase.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Bank Account Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPurchase.Focus();
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
                    cmbGST.Focus();
                }
            }
        }

        private void Quantity_KeyDown(object sender, KeyEventArgs e)
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
                    btnAdd.Focus();
                }
            }
        }

        void fetchSupplier()
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchSupplier", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbSupplierName.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string Supplierid;

        private void cmbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("select GSTIN from Supplier where SupplierName='" + cmbSupplierName.Text + "'", con);
            SqlDataReader dr1;
            dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                txtGST.Text=(dr1[0].ToString());
            }
            dr1.Close();
            
            SqlCommand cmd = new SqlCommand("Pro_FetchSupplierID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@SupplierName", SqlDbType.VarChar);
            p1.Value = cmbSupplierName.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                Supplierid = dr[0].ToString();

            }
            dr.Close();
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

        string productid;

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
                productid = dr[0].ToString();

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
                cmbGST.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string gstid;

        private void cmbGST_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchIDGST", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@GST", SqlDbType.VarChar);
            p1.Value = cmbGST.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                gstid = dr[0].ToString();

            }
            dr.Close();
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
                txtTotalAmount.Text = ((float.Parse(txtAmount.Text)) + float.Parse(txtAmount.Text) * float.Parse(cmbGST.Text) / 100).ToString();
            }
        }

        int i;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvPurchase.Rows.Clear();

            SqlCommand cmd = new SqlCommand("select ProductName,GST,Quantity,Amount,IMEI1,IMEI2 from tblSale", con);
            dr = cmd.ExecuteReader();
            i = 0;
            while (dr.Read())
            {
                dgvPurchase.Rows.Add();
                dgvPurchase.Rows[i].Cells[0].Value = dr[0];
                dgvPurchase.Rows[i].Cells[1].Value = dr[1];
                dgvPurchase.Rows[i].Cells[2].Value = dr[2];
                dgvPurchase.Rows[i].Cells[3].Value = dr[3];
                dgvPurchase.Rows[i].Cells[4].Value = dr[4];
                dgvPurchase.Rows[i].Cells[5].Value = dr[5];
              

               
                i++;
            }
            dr.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_InsertPurchase", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@InvoiceNo", SqlDbType.BigInt);
                p1.Value = txtInvoiceNo.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@SupplierName", SqlDbType.NVarChar);
                p1.Value = cmbSupplierName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ProductName", SqlDbType.NVarChar);
                p1.Value = cmbProductName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@GSTIN", SqlDbType.NVarChar);
                p1.Value = txtGST.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@PurchaseRate", SqlDbType.BigInt);
                p1.Value = txtPurchase.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@SaleRate", SqlDbType.BigInt);
                p1.Value = txtSale.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@GSTRate", SqlDbType.BigInt);
                p1.Value = cmbGST.Text;
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

                p1 = new SqlParameter("@PurchaseTransaction", SqlDbType.Int);
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

        private void frmPurchase_Load(object sender, EventArgs e)
        {

        }



    }
}
