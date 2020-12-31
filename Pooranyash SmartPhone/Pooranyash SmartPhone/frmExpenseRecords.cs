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
using System.IO;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;



namespace Pooranyash_SmartPhone
{
    public partial class frmExpenseRecords : Form
    {

        SqlConnection con = new SqlConnection("server=localhost;integrated security=true;database=PoornaYash");
        SqlDataReader dr;

        void clear()
        {
            cmbExpense.Text = "";
            txtExpenses.Text = "";
        }

        void clear1()
        {
            dtpDate.Text = "";
            cmbIncome.Text = "";
            txtExpens.Text = "";
            txtAmount.Text = "";
            txtPaymentMode.Text = "";
            txtPaymentRef.Text = "";
            txtRemark.Text = "";
        
        }

        public frmExpenseRecords()
        {
            InitializeComponent();
            con.Open();
            fetchExpenses();
            fetchExpenses1();
        }

        private void cmbState_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbExpense.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Method", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbExpense.Focus();
                }
                else
                {
                    txtExpenses.Focus();
                }
            }
        }

        private void txtExpenses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtExpenses.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Type ", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtExpenses.Focus();
                }
                else
                {
                    btnSave.Focus();
                }
            }
        }

        void fetchExpenses()
        {
            SqlCommand cmd = new SqlCommand("Pro_fetchIncome", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbExpense.Items.Add(dr[0]);

            }

            dr.Close();
        }
        string expenseid;

        private void cmbExpense_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Pro_FetchIncomeID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1;

            p1 = new SqlParameter("@Income", SqlDbType.NVarChar);
            p1.Value = cmbExpense.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                expenseid = dr[0].ToString();

            }
            dr.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             try
            {
                SqlCommand cmd = new SqlCommand("Pro_InsertAddExpense", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@ExpenseType", SqlDbType.NVarChar);
                p1.Value = cmbExpense.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ExpenseName", SqlDbType.NVarChar);
                p1.Value = txtExpenses.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@TransAddExpense", SqlDbType.Int);
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
                }

            }
             catch (Exception ex)
             {
                 MessageBox.Show("Error in Save Button" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        void fetchExpenses1()
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

            p1 = new SqlParameter("@Income", SqlDbType.NVarChar);
            p1.Value = cmbExpense.Text;
            cmd.Parameters.Add(p1);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                incomeid = dr[0].ToString();

            }
            dr.Close();
        }

        private void cmbIncome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbIncome.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Type ", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbIncome.Focus();
                }
                else
                {
                    txtExpens.Focus();
                }
            }
        }

        private void txtExpens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtExpens.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Type ", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtExpens.Focus();
                }
                else
                {
                    txtAmount.Focus();
                }
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAmount.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Type ", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Focus();
                }
                else
                {
                    txtPaymentMode.Focus();
                }
            }
        }

        private void txtPaymentMode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPaymentMode.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Type ", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPaymentMode.Focus();
                }
                else
                {
                    txtPaymentRef.Focus();
                }
            }
        }

        private void txtPaymentRef_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPaymentRef.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Type ", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPaymentRef.Focus();
                }
                else
                {
                    txtRemark.Focus();
                }
            }
        }

        private void txtRemark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtRemark.Text.Trim() == "")
                {
                    MessageBox.Show("Enter your Type ", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRemark.Focus();
                }
                else
                {
                    btnSave1.Focus();
                }
            }
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
             try
            {
                SqlCommand cmd = new SqlCommand("Pro_ExpenseInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;


                p1 = new SqlParameter("@Daet", SqlDbType.Date);
                p1.Value = dtpDate.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.Add(p1);

                
                p1 = new SqlParameter("@ExpenseorIncome", SqlDbType.NVarChar);
                p1.Value = cmbIncome.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ExpenseName", SqlDbType.NVarChar);
                p1.Value = txtExpens.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Amount", SqlDbType.BigInt);
                p1.Value = txtAmount.Text;
                cmd.Parameters.Add(p1);
                 
                p1 = new SqlParameter("@PaymentMode", SqlDbType.NVarChar);
                p1.Value = txtPaymentMode.Text;
                cmd.Parameters.Add(p1);

                 
                p1 = new SqlParameter("@PaymentRef", SqlDbType.NVarChar);
                p1.Value = txtPaymentRef.Text;
                cmd.Parameters.Add(p1);
                 
                p1 = new SqlParameter("@Remark", SqlDbType.NVarChar);
                p1.Value = txtRemark.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ExpensTransactionId", SqlDbType.Int);
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
                    clear1();
                }

            }
             catch (Exception ex)
             {
                 MessageBox.Show("Error in Save Button" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }
        int i;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string dtpDate=dtpDatefrom.Value.ToString("yyyy-MM-dd");
            string dtpDate2 = dtpdateto.Value.ToString("yyyy-MM-dd");
            SqlCommand cmd = new SqlCommand("select ExpenseID,Daet,ExpenseorIncome,ExpenseName,Amount,PaymentMode,PaymentRef,Remark from tblExpenses where Daet>='" + dtpDate + "'and Daet<='" + dtpDate2 + "'", con);
            dr = cmd.ExecuteReader();

            string datetim;
            

            dgvExpense.Rows.Clear();
            
            int i = 0;
            while (dr.Read())
            {
                dgvExpense.Rows.Add();
                dgvExpense.Rows[i].Cells[0].Value = dr[0];
                datetim = dr[1].ToString();
                dgvExpense.Rows[i].Cells[1].Value =DateTime.Parse(datetim);
                dgvExpense.Rows[i].Cells[2].Value = dr[2];

                dgvExpense.Rows[i].Cells[3].Value = dr[3];

                dgvExpense.Rows[i].Cells[4].Value = dr[4];

                dgvExpense.Rows[i].Cells[5].Value = dr[5];

                dgvExpense.Rows[i].Cells[6].Value = dr[6];
               // dgvExpense.Rows[i].Cells[7].Value = dr[7];
                i++;
            }
            dr.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = false;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Sheet1";
            // storing header part in Excel  
            for (int i = 1; i < dgvExpense.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvExpense.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgvExpense.Rows.Count; i++)
            {
                for (int j = 0; j < dgvExpense.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvExpense.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("e:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (dgvExpense.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (.pdf)|.pdf";
                sfd.FileName = "Purchase Details Report.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgvExpense.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            PdfPCell cell1 = new PdfPCell(new Phrase("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t Purchase Details Report"));
                            cell1.Colspan = dgvExpense.ColumnCount;
                            pdfTable.AddCell(cell1);

                            foreach (DataGridViewColumn column in dgvExpense.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvExpense.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(Convert.ToString(cell.Value));
                                    // or Below line code if you need to assign any default value if its null
                                    // here i assign empty string value if cell.Value is null or empty
                                    //  pdfTable.AddCell(!string.IsNullOrEmpty(cell.Value) ? Convert.ToString(cell.Value) : "");
                                    // pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4.Rotate(), 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();

                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
        string expid;
        private void dgvExpense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            expid = dgvExpense.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtpDate.Text = dgvExpense.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbIncome.Text = dgvExpense.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtExpens.Text = dgvExpense.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAmount.Text = dgvExpense.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPaymentMode.Text = dgvExpense.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPaymentRef.Text = dgvExpense.Rows[e.RowIndex].Cells[6].Value.ToString();
            //txtRemark.Text = dgvExpense.Rows[e.RowIndex].Cells[7].Value.ToString();
                
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Pro_ExpenseInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1;

                p1 = new SqlParameter("@ExpenseID", SqlDbType.BigInt);
                p1.Value =expid ;
                cmd.Parameters.Add(p1);


                p1 = new SqlParameter("@Daet", SqlDbType.Date);
                p1.Value = dtpDate.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.Add(p1);


                p1 = new SqlParameter("@ExpenseorIncome", SqlDbType.NVarChar);
                p1.Value = cmbIncome.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ExpenseName", SqlDbType.NVarChar);
                p1.Value = txtExpens.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Amount", SqlDbType.BigInt);
                p1.Value = txtAmount.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@PaymentMode", SqlDbType.NVarChar);
                p1.Value = txtPaymentMode.Text;
                cmd.Parameters.Add(p1);


                p1 = new SqlParameter("@PaymentRef", SqlDbType.NVarChar);
                p1.Value = txtPaymentRef.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@Remark", SqlDbType.NVarChar);
                p1.Value = txtRemark.Text;
                cmd.Parameters.Add(p1);

                p1 = new SqlParameter("@ExpensTransactionId", SqlDbType.Int);
                p1.Value = "2";
                cmd.Parameters.Add(p1);

                int n = cmd.ExecuteNonQuery();
                if (n < 0)
                {
                    MessageBox.Show("Data Not Deleted!!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Deleted!!", "System Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear1();
               }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Save Button" + ex, "System Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       



    }
}
