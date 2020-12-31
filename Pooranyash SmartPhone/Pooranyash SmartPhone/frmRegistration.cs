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
    public partial class frmRegistration : Form
    {

        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        SqlDataReader dr;

        public frmRegistration()
        {
            InitializeComponent();
            con.Open();
            filldata();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUsername.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Username", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Focus();
                }
                else
                {
                    txtPassword.Focus();
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Password", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
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
                SqlCommand cmd = new SqlCommand("Pro_InsertRegistration", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@RegUsername", SqlDbType.NVarChar);
                p1.Value = txtUsername.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@RegPassword", SqlDbType.NVarChar);
                p1.Value = txtPassword.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@RegTransactionId", SqlDbType.Int);
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
                    Login obj = new Login();
                    obj.Show();
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
                dgvRegistration.Rows.Clear();
                SqlCommand cmd = new SqlCommand("select * from Registration", con);

                dr = cmd.ExecuteReader();
                i = 0;
                while (dr.Read())
                {
                    dgvRegistration.Rows.Add();
                    dgvRegistration.Rows[i].Cells[0].Value = dr[0];
                    dgvRegistration.Rows[i].Cells[1].Value = dr[1];
                    dgvRegistration.Rows[i].Cells[2].Value = dr[2];



                    i++;

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "System says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string Gridid;
        private void dgvRegistration_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Gridid = dgvRegistration.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUsername.Text = dgvRegistration.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPassword.Text = dgvRegistration.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        bool valid()
        {

            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Enter your Username", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return false;
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Enter your Password", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return false;
            }
            {
                return true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_InsertRegistration", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@RegID", SqlDbType.NVarChar);
                p1.Value = Gridid;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@RegUsername", SqlDbType.NVarChar);
                p1.Value = txtUsername.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@RegPassword", SqlDbType.NVarChar);
                p1.Value = txtPassword.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@RegTransactionId", SqlDbType.Int);
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
                   Login obj = new Login();
                   obj.Show();
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