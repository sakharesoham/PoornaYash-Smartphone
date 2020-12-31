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
    public partial class frmDailySales : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        SqlDataReader dr;
        public frmDailySales()
        {
            InitializeComponent();
            con.Open();
        }

        int i;
        private void btnView_Click(object sender, EventArgs e)
        {
            dgvDaily.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select ProductName,Quantity,SaleRate,TotalAmount from Purchase", con);
            dr = cmd.ExecuteReader();
            i = 0;
            while (dr.Read())
            {
                dgvDaily.Rows.Add();
                dgvDaily.Rows[i].Cells[0].Value = dr[0];
                dgvDaily.Rows[i].Cells[1].Value = dr[1];
                dgvDaily.Rows[i].Cells[2].Value = dr[2];
                dgvDaily.Rows[i].Cells[3].Value = dr[3];
                i++;
            }
            dr.Close();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
           
        }
    }
}
