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
    public partial class frmMultipleState : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        public frmMultipleState()
        {
            InitializeComponent();
            con.Open();
        }

        private void txtState_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtState.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your State ", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtState.Focus();
                }
                else
                {
                    btnStateSave.Focus();
                }
            }
        }

        private void btnStateSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_InsertStateNames", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@StateName", SqlDbType.NVarChar);
                p1.Value = txtState.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@StateTransactionId", SqlDbType.Int);
                p1.Value = "1";
                cmd.Parameters.Add(p1);

                int n = cmd.ExecuteNonQuery();
                if (n < 0)
                {
                    MessageBox.Show("Data Not Saved", "System says", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Data Saved", "System says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Save Button" +ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
