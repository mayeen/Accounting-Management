using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountingManagement.View;
using AccountingManagement.Controller;
using AccountingManagement.Model;

namespace AccountingManagement.View

{
    public partial class EditForm : Form
    {
        int paidBy = 0, transactionType = 0, amount = 0;
        string employeeID = "dont work", narration = "dont work";
        DateTime date;
        int voucherNo = 0;
        public EditForm()
        {
            InitializeComponent();
        }
        MainForm mainForm = new MainForm();
        public void AddDataTransactionComboBox()
        {
            DataTable dt = AccountControl.TransactionSelectedDataControl(paidBy);
            TransactionTypeComboBox.ValueMember = dt.Columns[0].ColumnName;
            TransactionTypeComboBox.DisplayMember = dt.Columns[1].ColumnName;
            TransactionTypeComboBox.DataSource = dt;

        }
        public void AddDataPaidByComboBox()
        {
            DataTable dt = AccountControl.PaidByDataControl();
            PaidByComboBox.ValueMember = dt.Columns[0].ColumnName;
            PaidByComboBox.DisplayMember = dt.Columns[1].ColumnName;
            PaidByComboBox.DataSource = dt;


        }
        public void AddDataAuthorisedByComboBox()
        {
            DataTable dt = EmployeeControl.EmployeeDataControl();
            AuthorisedByComboBox.ValueMember = dt.Columns[0].ColumnName;

            AuthorisedByComboBox.DisplayMember = dt.Columns[1].ColumnName;
            AuthorisedByComboBox.DataSource = dt;

        }

        private static void EditForm_Load(object sender, EventArgs e)
        {
         
        }

        private void EditForm_Load_1(object sender, EventArgs e)
       {
            AddDataAuthorisedByComboBox();
            AddDataPaidByComboBox();
            voucherNo = Convert.ToInt32(EditVoucherLabel.Text);
        }

        private void EditPaidByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            paidBy = Int32.Parse((string)cmb.SelectedValue);
            DataTable dt = AccountControl.TransactionSelectedDataControl(paidBy);
            //  AddDataTransactionComboBox();
            TransactionTypeComboBox.ValueMember = dt.Columns[0].ColumnName;
            TransactionTypeComboBox.DisplayMember = dt.Columns[1].ColumnName;
            TransactionTypeComboBox.DataSource = dt;
        }

        private void EditTransactionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            transactionType = Int32.Parse((string)cmb.SelectedValue);
        }

        private void EditNarrationTextBox_TextChanged(object sender, EventArgs e)
        {
            narration = NarrationTextBox.Text;
        }

        private void EditVoucherLabel_Click(object sender, EventArgs e)
        {

        }

        private void EditAuthorisedByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            employeeID = (string)cmb.SelectedValue;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            VoucherControl voucher = new VoucherControl();
            voucher.UpdateIntoVoucherControl(voucherNo, paidBy, transactionType, amount, narration, date, employeeID);
            MessageBox.Show("Your transaction has been editted successfully");
        }

        private void EditAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            amount = Convert.ToInt32(AmountTextBox.Text);
        }
    }
}
