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
    public partial class frmMultipleDistrict : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        public frmMultipleDistrict()
        {
            InitializeComponent();
            con.Open();
            fetchState();
        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {

        }

        void fetchState()
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchStateName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbStateName.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string stateid;
        private void cmbStateName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchIDState", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@StateName", SqlDbType.NVarChar);
            p1.Value = cmbStateName.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                stateid = dr[0].ToString();

            }
            dr.Close();

            
            
        }

        private void txtDistrict_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtDistrict.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your District ", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDistrict.Focus();
                }
                else
                {
                    btnDistrictSave.Focus();
                }
            }
        }

        private void btnDistrictSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_InsertDistrictNames", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@StateID", SqlDbType.NVarChar);
                p1.Value = stateid;
                cmd.Parameters.Add(p1);

               
                p1 = new SqlParameter("@DistrictName", SqlDbType.NVarChar);
                p1.Value = txtDistrict.Text;
                cmd.Parameters.Add(p1);


                p1 = new SqlParameter("@DistrictTransactionId", SqlDbType.Int);
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
                MessageBox.Show("Error in Save Button" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
