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
    public partial class frmMultipleTaluka : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        public frmMultipleTaluka()
        {
            InitializeComponent();
            con.Open();
            fetchDistrict();
        }

        void fetchDistrict()
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchDistrictName", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbDistrictName.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string districtid;
        private void cmbDistrictName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchIDDistrict", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@DistrictName", SqlDbType.NVarChar);
            p1.Value = cmbDistrictName.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                districtid = dr[0].ToString();

            }
            dr.Close();
        }

        private void btnTalukaSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_InsertTalukaNames", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@DistrictID", SqlDbType.BigInt);
                p1.Value = districtid;
                cmd.Parameters.Add(p1);


                p1 = new SqlParameter("@TalukaName", SqlDbType.NVarChar);
                p1.Value = txtTaluka.Text;
                cmd.Parameters.Add(p1);


                p1 = new SqlParameter("@TalukaTransactionId", SqlDbType.Int);
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
