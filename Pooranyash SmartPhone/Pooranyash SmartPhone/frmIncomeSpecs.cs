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
    public partial class frmIncomeSpecs : Form
    {

        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        SqlDataReader dr;

        void clear()
        {
            txtIncome.Text = "";
        }
        public frmIncomeSpecs()
        {
            InitializeComponent();
            con.Open();
            fetchIncome();
            filldata();
        }

        private void frmIncomeSpecs_Load(object sender, EventArgs e)
        {

        }

        void fetchIncome()
        {
            SqlCommand cmd = new SqlCommand("Pro_fetchIncome", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbIncome.Items.Add(dr[0]);

            }

            dr.Close();
        }

        string incomeid;
        private void cmbIncome_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchIncomeID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@Income", SqlDbType.VarChar);
            p1.Value = cmbIncome.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                incomeid = dr[0].ToString();

            }
            dr.Close();
        }

        private void txtIncome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtIncome.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Type", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIncome.Focus();
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
                SqlCommand cmd = new SqlCommand("Pro_InsertIncomeType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@IncomeExpense", SqlDbType.NVarChar);
                p1.Value = cmbIncome.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@IncomeExpensetype", SqlDbType.NVarChar);
                p1.Value = txtIncome.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@IncomeTransact", SqlDbType.Int);
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
                    clear();
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
                dgvIncome.Rows.Clear();
                SqlCommand cmd = new SqlCommand("select * from Incomedetails", con);

                dr = cmd.ExecuteReader();
                i = 0;
                while (dr.Read())
                {
                    dgvIncome.Rows.Add();
                    dgvIncome.Rows[i].Cells[0].Value = dr[0];
                    dgvIncome.Rows[i].Cells[1].Value = dr[1];
                    dgvIncome.Rows[i].Cells[2].Value = dr[2];
                   i++;

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "System says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
