using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pooranyash_SmartPhone
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBank_Master obj = new frmBank_Master();
            obj.Show();
        }

        private void gSTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGST_Master obj = new frmGST_Master();
            obj.Show();
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBrandName obj = new frmBrandName();
            obj.Show();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColorMaster obj = new frmColorMaster();
            obj.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBankTransaction obj = new frmBankTransaction();
            obj.Show();
        }

        private void registerProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void purchaseProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchase obj = new frmPurchase();
            obj.Show();
        }

        private void rechargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRechargeCompanyMaster obj = new frmRechargeCompanyMaster();
            obj.Show();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void supplierRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dailySalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDailySales obj = new frmDailySales();
            obj.Show();
        }

        private void saleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSale obj = new frmSale();
            obj.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductRegistration obj = new frmProductRegistration();
            obj.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplierRegistration obj = new frmSupplierRegistration();
            obj.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeRegistration obj = new frmEmployeeRegistration();
            obj.Show();
        }

        private void firmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFirmRegistration obj = new frmFirmRegistration();
            obj.Show();
        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpenseRecords obj = new frmExpenseRecords();
            obj.Show();
        }
    }
}
