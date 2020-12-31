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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
            con.Open();
        }

        private void Login_Load(object sender, EventArgs e)
        {

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
                    btnLogin.Focus();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("select RegUsername,RegPassword from Registration where RegUsername='" + txtUsername.Text + "' and RegPassword='" + txtPassword.Text + "'", con);

                dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    MessageBox.Show("Login Successful!!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain obj = new frmMain();
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Login" + ex, "System says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
