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
    public partial class frmMultipleDependencies : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        public frmMultipleDependencies()
        {
            InitializeComponent();
            con.Open();
            fetchState();
            fetchDistrict();
        }

        void fetchState()
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchStateName", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbState.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string sid;

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchIDState", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@StateName", SqlDbType.NVarChar);
            p1.Value = cmbState.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                sid = dr[0].ToString();

            }
            dr.Close();

            SqlCommand cmd1 = new SqlCommand("select DistrictName,DistrictID from District where StateID=" + int.Parse(sid), con);
            dr = cmd1.ExecuteReader();
            cmbDistrict.Items.Clear();

            while (dr.Read())
            {
                cmbDistrict.Items.Add(dr[0].ToString());
               
            }
            dr.Close();
             
        }


        void fetchDistrict()
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchDistrictName", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbDistrict.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string talid;
        private void cmbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchIDDistrict", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@DistrictName", SqlDbType.NVarChar);
            p1.Value = cmbDistrict.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                talid = dr[0].ToString();

            }
            dr.Close();

            SqlCommand cmd1 = new SqlCommand("select TalukaName,TalukaID from Taluka where DistrictID=" + int.Parse(talid), con);
            dr = cmd1.ExecuteReader();
            cmbTaluka.Items.Clear();

            while (dr.Read())
            {
                cmbTaluka.Items.Add(dr[0].ToString());

            }
            dr.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_insertSave", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@SaveState", SqlDbType.NVarChar);
                p1.Value = cmbState.Text;
                cmd.Parameters.Add(p1);


                p1 = new SqlParameter("@SaveDistrict", SqlDbType.NVarChar);
                p1.Value = cmbDistrict.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@SaveTaluka", SqlDbType.NVarChar);
                p1.Value = cmbTaluka.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Savetransactionid", SqlDbType.Int);
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
