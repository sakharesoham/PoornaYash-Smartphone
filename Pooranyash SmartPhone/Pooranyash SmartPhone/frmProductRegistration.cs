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
    public partial class frmProductRegistration : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        SqlDataReader dr;
        public frmProductRegistration()
        {
            InitializeComponent();
            con.Open();
            fetchBrand();
            fetchColor();
            fetchGST();
            fetchProduct();
            
        }

        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtProductName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Invoice Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtProductName.Focus();
                }
                else
                {
                    cmbBrandName.Focus();
                }
            }
        }

        private void txtHSNCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtHSNCode.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Invoice Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHSNCode.Focus();
                }
                else
                {
                    cmbColor.Focus();
                }
            }
        }

        private void txtStockLimit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtHSNCode.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Invoice Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHSNCode.Focus();
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
                    MessageBox.Show("Enter your Invoice Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQuantity.Focus();
                }
                else
                {
                    txtPurchaseRate.Focus();
                }
            }
        }

        private void txtPurchaseRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPurchaseRate.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Invoice Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPurchaseRate.Focus();
                }
                else
                {
                    txtSalePrice.Focus();
                }
            }
        }

        private void txtSalePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSalePrice.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Invoice Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSalePrice.Focus();
                }
                else
                {
                    txtMRP.Focus();
                }
            }
        }

        private void txtMRP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMRP.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Invoice Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMRP.Focus();
                }
                else
                {
                    txtMOP.Focus();
                }
            }
        }

        private void txtMOP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMOP.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Invoice Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMOP.Focus();
                }
                else
                {
                    cmbGST.Focus();
                }
            }
        }

        private void txtCGST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCGST.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Invoice Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCGST.Focus();
                }
                else
                {
                    txtSGST.Focus();
                }
            }
        }

        private void txtSGST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSGST.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Invoice Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSGST.Focus();
                }
                else
                {
                    btnSave.Focus();
                }
            }
        }

        void fetchBrand()
        {
            SqlCommand cmd = new SqlCommand("Pro_BrandName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbBrandName.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string BrandId;
        private void cmbBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchBrandID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@BrandName", SqlDbType.VarChar);
            p1.Value = cmbBrandName.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                BrandId = dr[0].ToString();

            }
            dr.Close();
        }

        void fetchColor()
        {
            SqlCommand cmd = new SqlCommand("Pro_ColorName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbColor.Items.Add(dr[0]);

            }

            dr.Close();
        }
        string ColorId;

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select ColorID from tblColor where ColorName='" + cmbColor.SelectedItem.ToString() + "'", con);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                ColorId = dr[0].ToString();

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
            SqlCommand cmd = new SqlCommand("select GSTID,CGST,SGST from tblGST where GST='" + cmbGST.SelectedItem.ToString() + "'", con);
            dr = cmd.ExecuteReader();
            //cmbMedicineName.Items.Clear();

            while (dr.Read())
            {
                gstid = dr[0].ToString();
                txtCGST.Text = dr[1].ToString();
                txtSGST.Text = dr[2].ToString();
            }
            dr.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_InsertProduct", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@ProductName", SqlDbType.NVarChar);
                p1.Value = txtProductName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@BrandName", SqlDbType.NVarChar);
                p1.Value = cmbBrandName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@HSNCode", SqlDbType.BigInt);
                p1.Value = txtHSNCode.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ColorID", SqlDbType.BigInt);
                p1.Value = ColorId;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@StockLimit", SqlDbType.BigInt);
                p1.Value = txtStockLimit.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Quantity", SqlDbType.BigInt);
                p1.Value = txtQuantity.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@PurchaseRate", SqlDbType.BigInt);
                p1.Value = txtPurchaseRate.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@SalePrice", SqlDbType.BigInt);
                p1.Value = txtSalePrice.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@MRP", SqlDbType.BigInt);
                p1.Value = txtMRP.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@MOP", SqlDbType.BigInt);
                p1.Value = txtMOP.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@TotalGST", SqlDbType.BigInt);
                p1.Value = cmbGST.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@CGST", SqlDbType.BigInt);
                p1.Value = txtCGST.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@SGST", SqlDbType.BigInt);
                p1.Value = txtSGST.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@TransProduct", SqlDbType.Int);
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
                    fetchProduct();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Save Button" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmbSearchProduct.Items.Add(dr[0]);

            }

            dr.Close();
        }

        
        int i;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvBill.Rows.Clear();


            SqlCommand cmd = new SqlCommand("select ProductID,ProductName,BrandName,HSNCode,ColorName,StockLimit,Quantity,PurchaseRate,SalePrice,MRP,MOP,TotalGST,CGST,SGST from ProductDetails  tp, tblColor co where co.ColorID=tp.ColorID and ProductName='" + cmbSearchProduct.Text + "'", con);
            dr = cmd.ExecuteReader();
            i = 0;
            while (dr.Read())
            {
                dgvBill.Rows.Add();
                dgvBill.Rows[i].Cells[0].Value = dr[0];
                dgvBill.Rows[i].Cells[1].Value = dr[1];
                dgvBill.Rows[i].Cells[2].Value = dr[2];
                dgvBill.Rows[i].Cells[3].Value = dr[3];
                dgvBill.Rows[i].Cells[4].Value = dr[4];
                dgvBill.Rows[i].Cells[5].Value = dr[5];
                dgvBill.Rows[i].Cells[6].Value = dr[6];
                dgvBill.Rows[i].Cells[7].Value = dr[7];
                dgvBill.Rows[i].Cells[8].Value = dr[8];
                dgvBill.Rows[i].Cells[9].Value = dr[9];
                dgvBill.Rows[i].Cells[10].Value = dr[10];
                dgvBill.Rows[i].Cells[11].Value = dr[11];
                dgvBill.Rows[i].Cells[12].Value = dr[12];
                dgvBill.Rows[i].Cells[13].Value = dr[13];
                i++;
            }
            dr.Close();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }
    }
}
