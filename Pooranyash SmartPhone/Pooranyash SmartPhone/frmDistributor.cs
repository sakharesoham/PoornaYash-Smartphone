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
using GenericFeatures;
using System.IO;

namespace Pooranyash_SmartPhone
{
    public partial class frmDistributor : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        SqlDataReader dr;

        public frmDistributor()
        {
            InitializeComponent();
            con.Open();
            fetchBrand();
            fetchstate();
            fetchDist();
        }

        private void frmDistributor_Load(object sender, EventArgs e)
        {

        }
        string type;
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (rbtnR.Checked)
                    type = "Registered";
                else if (rbtnUR.Checked)
                    type = "UnRegistered";

                SqlCommand cmd = new SqlCommand("Pro_InsertDistributor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@Datee", SqlDbType.Date);
                p1.Value= dtpDate.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Disttype", SqlDbType.NVarChar);
                p1.Value = type;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@BrandName", SqlDbType.NVarChar);
                p1.Value = cmbbrand.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@DistName", SqlDbType.NVarChar);
                p1.Value = txtDistName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@DistGST", SqlDbType.NVarChar);
                p1.Value = txtCompGST.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@DistContactName", SqlDbType.NVarChar);
                p1.Value = txtContName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@DistContNo", SqlDbType.BigInt);
                p1.Value = txtContNo.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@DistAddress", SqlDbType.NVarChar);
                p1.Value = txtCompAddress.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@DistState", SqlDbType.NVarChar);
                p1.Value = cmbState.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@DistCity", SqlDbType.NVarChar);
                p1.Value = txtCit.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Distbank", SqlDbType.NVarChar);
                p1.Value = txtbankname.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@DistAcc", SqlDbType.BigInt);
                p1.Value = txtAccoNo.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@DistIFSc", SqlDbType.NVarChar);
                p1.Value = txtbIFSC.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@DistMicr", SqlDbType.NVarChar);
                p1.Value = txtbMICR.Text;
                cmd.Parameters.Add(p1);



                p1 = new SqlParameter("@DistTransactionId", SqlDbType.Int);
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
                    fetchDist();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Save Button" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmbbrand.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string brandid;
        private void cmbbrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchBrandID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@BrandName", SqlDbType.VarChar);
            p1.Value = cmbbrand.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                brandid = dr[0].ToString();

            }
            dr.Close();
        }

        void fetchstate()
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchState", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbState.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string stateid;

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchStateID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@StateName", SqlDbType.VarChar);
            p1.Value = cmbState.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                stateid = dr[0].ToString();

            }
            dr.Close();
        }

       
        void fetchDist()
        {
            SqlCommand cmd = new SqlCommand("Pro_DistFetch", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbSearch.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string distid;

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchDistID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@DistName", SqlDbType.VarChar);
            p1.Value = cmbSearch.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                distid = dr[0].ToString();

            }
            dr.Close();
        }
        int i;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvDistributor.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select Datee,Disttype,BrandName,DistName,DistGST,DistContactName,DistContNo,DistAddress,DistState,DistCity from tblDistributor where DistName='" + cmbSearch.Text + "'", con);

            dr = cmd.ExecuteReader();
            i = 0;
            if (dr.Read())
            {
                dgvDistributor.Rows.Add();
                dgvDistributor.Rows[i].Cells[0].Value = dr[0];
                dgvDistributor.Rows[i].Cells[1].Value = dr[1];
                dgvDistributor.Rows[i].Cells[2].Value = dr[2];
                dgvDistributor.Rows[i].Cells[3].Value = dr[3];
                dgvDistributor.Rows[i].Cells[4].Value = dr[4];
                dgvDistributor.Rows[i].Cells[5].Value = dr[5];
                dgvDistributor.Rows[i].Cells[6].Value = dr[6];
                dgvDistributor.Rows[i].Cells[7].Value = dr[7];
                dgvDistributor.Rows[i].Cells[8].Value = dr[8];
                dgvDistributor.Rows[i].Cells[9].Value = dr[9];

                i++;

            }
            dr.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
