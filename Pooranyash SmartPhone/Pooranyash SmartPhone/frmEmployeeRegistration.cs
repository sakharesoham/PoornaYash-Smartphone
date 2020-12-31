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
    public partial class frmEmployeeRegistration : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        SqlDataReader dr;

        void enablefalse()
        {
            txtDesig.Enabled = false;
            txtEmpid.Enabled = false;
            txtJoining.Enabled = false;
            txtemplname.Enabled = false;
            txtCont.Enabled = false;
            txtAddres.Enabled = false;
            txtprom.Enabled = false;
            txtProvident.Enabled = false;
            txtRefAdd.Enabled = false;
        }

        void clear()
        {
            txtID.Text = "";
            txtDesignation.Text = "";
            txtPromoted.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            cmbGender.Text = "";
            txtQualification.Text = "";
            txtSalary.Text = "";
            txtPFNo.Text = "";
            txtRefName.Text = "";
            pbIDProof.Image = null;
            pbPic.Image = null;
        }

        public frmEmployeeRegistration()
        {
            InitializeComponent();
            con.Open();
            fetchEmploye();
            fetchEmploye1();
            fetchEmploye2();
            fetchEmploye3();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void grpEmployee_Enter(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtID.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Employee Name", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Focus();
                }
                else
                {
                    txtDesignation.Focus();
                }
            }
        }

        private void txtDesignation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtDesignation.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Designation", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDesignation.Focus();
                }
                else
                {
                    txtPromoted.Focus();
                }
            }
        }

        private void txtPromoted_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPromoted.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Mentor", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPromoted.Focus();
                }
                else
                {
                    txtName.Focus();
                }
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Name", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Focus();
                }
                else
                {
                    txtAddress.Focus();
                }
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAddress.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Address", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAddress.Focus();
                }
                else
                {
                    txtContact.Focus();
                }
            }
        }

        private void txtContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtContact.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Contact Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtContact.Focus();
                }
                else
                {
                    txtQualification.Focus();
                }
            }
        }

        private void txtQualification_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtQualification.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Qualification", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQualification.Focus();
                }
                else
                {
                    cmbGender.Focus();
                }
            }
        }

        private void txtMale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbGender.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Qualification", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbGender.Focus();
                }
                else
                {
                    txtSalary.Focus();
                }
            }
        }

        private void txtSalary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSalary.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Salary", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSalary.Focus();
                }
                else
                {
                    txtPFNo.Focus();
                }
            }
        }

        private void txtPFNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPFNo.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your PF Number", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPFNo.Focus();
                }
                else
                {
                    txtRefName.Focus();
                }
            }
        }

        private void txtRefName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtRefName.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Referal Name", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRefName.Focus();
                }
                else
                {
                    btnSave.Focus();
                }
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.AllowOnlyNumeric(sender, e);
        }

        private void txtDesignation_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.AllowOnlyAlphabets(sender, e);
        }

        private void txtPromoted_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.AllowOnlyAlphabets(sender, e);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.AllowOnlyAlphabets(sender, e);
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.AllowOnlyAlphaNumeric(sender, e);
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.AllowOnlyNumeric(sender, e);
        }

        private void txtQualification_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.AllowOnlyAlphabets(sender, e);
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.AllowOnlyNumeric(sender, e);
        }

        private void txtPFNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.AllowOnlyNumeric(sender, e);
        }

        private void txtRefName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.AllowOnlyAlphaNumeric(sender, e);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbIDProof.Image = new Bitmap(open.FileName);
                // image file path  
                txtIDProof.Text = open.FileName;
            }
        }

        private void lblUploadPic_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg;*.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbPic.Image = new Bitmap(open.FileName);
                // image file path  
                txtPic.Text = open.FileName;
            }
        }

        void fetchEmploye()
        {
            cmbEmployee.Items.Clear();
            SqlCommand cmd = new SqlCommand("Pro_FetchEmployeeName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbEmployee.Items.Add(dr[0]);
                

            }

            dr.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.Copy(txtIDProof.Text, Path.Combine(@"F:\PooraYash Infotech\Pooranyash SmartPhone\Pooranyash SmartPhone\ID proof", Path.GetFileName(txtIDProof.Text)), true);
            File.Copy(txtPic.Text, Path.Combine(@"F:\PooraYash Infotech\Pooranyash SmartPhone\Pooranyash SmartPhone\photo", Path.GetFileName(txtPic.Text)), true);

            try
            {
                SqlCommand cmd = new SqlCommand("Pro_Employeeinsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@JoiningDate", SqlDbType.Date);
                p1.Value = dtpJoinDate.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@EmpID", SqlDbType.BigInt);
                p1.Value = txtID.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Designation", SqlDbType.NVarChar);
                p1.Value = txtDesignation.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Promotedby", SqlDbType.NVarChar);
                p1.Value = txtPromoted.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@NameofPerson", SqlDbType.NVarChar);
                p1.Value = txtName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Addres", SqlDbType.NVarChar);
                p1.Value = txtAddress.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ContactNo", SqlDbType.BigInt);
                p1.Value = txtContact.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Gender", SqlDbType.NVarChar);
                p1.Value = cmbGender.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Qualification", SqlDbType.NVarChar);
                p1.Value = txtQualification.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@salary", SqlDbType.BigInt);
                p1.Value = txtSalary.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@PF", SqlDbType.BigInt);
                p1.Value = txtPFNo.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ReferenceDetails", SqlDbType.NVarChar);
                p1.Value = txtRefName.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@idproof", SqlDbType.NVarChar);
                p1.Value = txtIDProof.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@idimage", SqlDbType.NVarChar);
                p1.Value = txtPic.Text;
                cmd.Parameters.Add(p1);



                p1 = new SqlParameter("@EmpTransactionId", SqlDbType.Int);
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
                    clear();
                    fetchEmploye();
                    fetchEmploye1();
                    fetchEmploye2();
                    fetchEmploye3();
                    enablefalse();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Save Button" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        string empid;

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Pro_FetchEmployeeId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@NameofPerson", SqlDbType.NVarChar);
            p1.Value = cmbEmployee.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                empid = dr[0].ToString();

            }
            dr.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Designation,EmpID,JoiningDate,NameofPerson,ContactNo,Addres,Promotedby,PF,ReferenceDetails,idproof,idimage from Employee where NameofPerson='" + cmbEmployee .Text+ "'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtDesig.Text = dr[0].ToString();
                txtEmpid.Text = dr[1].ToString();
                txtJoining.Text = dr[2].ToString();
                txtemplname.Text = dr[3].ToString();
                txtCont.Text = dr[4].ToString();
                txtAddres.Text = dr[5].ToString();
                txtprom.Text = dr[6].ToString();
                txtProvident.Text = dr[7].ToString();
                txtRefAdd.Text = dr[8].ToString();
                
                txtsearchphoto.Text = dr[9].ToString();
                pbid.Image = new Bitmap(dr[9].ToString());

                txtsearchpic.Text = dr[10].ToString();
                pbpicture.Image = new Bitmap(dr[10].ToString());


            }
                        dr.Close();
                        enablefalse();
        }

        private void label31_Click(object sender, EventArgs e)                                          //Present Button
        {
            
            

        }

        void fetchEmploye1()
        {
            cmbEmp.Items.Clear();
            SqlCommand cmd = new SqlCommand("Pro_FetchEmployeeName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
               
                cmbEmp.Items.Add(dr[0]);

            }

            dr.Close();
        }

        private void cmbEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblAbsent_Click(object sender, EventArgs e)
        {
            
        }

        private void label31_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_insertattend", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@NameofPerson", SqlDbType.NVarChar);
                p1.Value = cmbEmp.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ispresent", SqlDbType.BigInt);
                p1.Value = 1;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Date", SqlDbType.Date);
                p1.Value = dtpDate.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@attendtransaction", SqlDbType.Int);
                p1.Value = "1";
                cmd.Parameters.Add(p1);

                int n = cmd.ExecuteNonQuery();
                if (n < 0)
                {
                    MessageBox.Show("Data Not Saved!!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Employee Present!!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Present Button" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lblAbsent_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_insertattend", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@NameofPerson", SqlDbType.NVarChar);
                p1.Value = cmbEmp.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ispresent", SqlDbType.BigInt);
                p1.Value = 0;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Date", SqlDbType.Date);
                p1.Value = dtpDate.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@attendtransaction", SqlDbType.Int);
                p1.Value = "1";
                cmd.Parameters.Add(p1);

                int n = cmd.ExecuteNonQuery();
                if (n < 0)
                {
                    MessageBox.Show("Data Not Saved!!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Employee Absent!!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Absent Button" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEmp_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        void fetchEmploye2()
        {
            cmbRecords.Items.Clear();
            SqlCommand cmd = new SqlCommand("Pro_FetchEmployeeName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                cmbRecords.Items.Add(dr[0]);

            }

            dr.Close();
        }

        private void btnSearchRecords_Click(object sender, EventArgs e)
        {
            string dtpDate = dtpDatefrom.Value.ToString("yyyy-MM-dd");
            string dtpDate2 = dtpdateto.Value.ToString("yyyy-MM-dd");
            SqlCommand cmd = new SqlCommand("select NameofPerson,ispresent,Date from Attendance where NameofPerson='"+cmbRecords.Text+"' and  Date>='" + dtpDate + "'and Date<='" + dtpDate2 + "' order by Date asc", con);
            dr = cmd.ExecuteReader();

            dgvRecords.Rows.Clear();
            int i = 0;
            while (dr.Read())
            {
                dgvRecords.Rows.Add();
                dgvRecords.Rows[i].Cells[0].Value = dr[0];
                dgvRecords.Rows[i].Cells[1].Value = dr[1];
                dgvRecords.Rows[i].Cells[2].Value = dr[2];
               

                i++;
            }
            dr.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();      // creating Excel Application

            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);                    // creating new WorkBook within Excel application 

            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;                                             // creating new Excelsheet in workbook

            app.Visible = false;                                                                                    // see the excel sheet behind the program  

            worksheet = workbook.Sheets["Sheet1"];                                                                  // get the reference of first sheet. By default its name is Sheet1.  

            worksheet = workbook.ActiveSheet;                                                                       // store its reference to worksheet  

            worksheet.Name = "Sheet1";                                                                              // changing the name of active sheet  

            for (int i = 1; i < dgvRecords.Columns.Count + 1; i++)                                                  // storing header part in Excel  
            {
                worksheet.Cells[1, i] = dgvRecords.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgvRecords.Rows.Count; i++)                                                         // storing Each row and column value to excel sheet 
            {
                for (int j = 0; j < dgvRecords.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvRecords.Rows[i].Cells[j].Value.ToString();
                }
            }
                                                                                                                    // save the application  
            workbook.SaveAs("e:\\Records.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            app.Quit();                                                                                             // Exit from the application  
        }


        void fetchEmploye3()
        {
            cmbEmpTrans.Items.Clear();
            SqlCommand cmd = new SqlCommand("Pro_FetchEmployeeName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                cmbEmpTrans.Items.Add(dr[0]);

            }

            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)                                                      //Save Button of Transaction
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_InsertEmpTransaction", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@EmpName", SqlDbType.NVarChar);
                p1.Value = cmbEmpTrans.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@PaymentStatus", SqlDbType.NVarChar);
                p1.Value = cmbPayStatus.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Amount", SqlDbType.BigInt);
                p1.Value = txtEmpAmount.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@EmpTransactId", SqlDbType.Int);
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

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Transaction Save Button" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
