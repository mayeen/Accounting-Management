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
using AccountingManagement.Model;
using AccountingManagement.Controller;
using AccountingManagement.View;

namespace AccountingManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        int paidBy = 0, transactionType = 0,amount=0;
        string employeeID = "dont work",narration="dont work";
        DateTime date;
        int VoucherNumber = 0;
        public void GetStuff()
        {
            BindingSource bindingSource = new BindingSource();
            VoucherControl voucher = new VoucherControl();
            var item = voucher.VoucherDataControl();

            //show in dataGridView
            bindingSource.DataSource = item;
            dataGridView.DataSource = bindingSource;
            
            //show in list view
               foreach (var user in item)
                {
                    ListViewItem lv = new ListViewItem(user.voucherNo.ToString());

                    lv.SubItems.Add(user.Debit.ToString());
                    lv.SubItems.Add(user.Amount.ToString());
                    lv.SubItems.Add(user.Credit.ToString());
                    lv.SubItems.Add(user.Date.ToString());
                    lv.SubItems.Add(user.Narration.ToString());
                    lv.SubItems.Add(user.Authentication.ToString());

                
                listView.Items.Add(lv);
                }

                listView.Columns.Add("Voucher Number", 100, HorizontalAlignment.Left);
                listView.Columns.Add("Debit", 100, HorizontalAlignment.Left);
                listView.Columns.Add("Amount", 100, HorizontalAlignment.Left);
                listView.Columns.Add("Credit", 100, HorizontalAlignment.Left);
                listView.Columns.Add("Date", 100, HorizontalAlignment.Left);
                listView.Columns.Add("Narration", 100, HorizontalAlignment.Left);
                listView.Columns.Add("Authentication By", 100, HorizontalAlignment.Left);

            
        }
        public void showVoucherID()
        {
            VoucherQuery vm = new VoucherQuery();
            VoucherControl vController = new VoucherControl();

            int i = vController.getVoucherID(vm);
            VoucherLabel.Text = i.ToString();
            //Console.WriteLine(i);
        }
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
       

        private void Form1_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToLongDateString();
            date = DateTime.Now;

            
            //call method to populate AuthorisedBy ComboBox
            AddDataAuthorisedByComboBox();

            //call method to populate Account related ComboBoxes
           // AddDataTransactionComboBox();
            AddDataPaidByComboBox();
            GetStuff();
            showVoucherID();


            // here I have populated Account Table with data that will work only one time 
            //AccountQuery acc = new AccountQuery();
            //acc.AccountDataEntry();

        }

        private void AuthorisedByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            employeeID = (string) cmb.SelectedValue;
           //MessageBox.Show(selectedValue);
        }

        private void TransactionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // DataTable dt = AccountQuery.AccountTable();
            ComboBox cmb = (ComboBox)sender;
            transactionType = Int32.Parse((string)cmb.SelectedValue);
            //  MessageBox.Show(selectedValue.ToString());
        }

        private void PaidByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            paidBy = Int32.Parse((string)cmb.SelectedValue);
            DataTable dt= AccountControl.TransactionSelectedDataControl(paidBy);
            //  AddDataTransactionComboBox();
            TransactionTypeComboBox.ValueMember = dt.Columns[0].ColumnName;
            TransactionTypeComboBox.DisplayMember = dt.Columns[1].ColumnName;
            TransactionTypeComboBox.DataSource = dt;

            //MessageBox.Show(selectedValue.ToString());

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditForm up = new EditForm();
            up.EditVoucherLabel.Text = this.dataGridView.CurrentRow.Cells[0].Value.ToString();
             VoucherNumber = Convert.ToInt32(up.EditVoucherLabel.Text);
            //up.TransactionComboBox.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            up.AmountTextBox.Text = this.dataGridView.CurrentRow.Cells[2].Value.ToString();
            up.EditDateLabel.Text = this.dataGridView.CurrentRow.Cells[3].Value.ToString();
            //up.PaidByComboBox.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //up.AuthorisedByComboBox.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

            up.Show();
        }

        private void NarrationTextBox_TextChanged_1(object sender, EventArgs e)
        {
            narration = NarrationTextBox.Text;
            
        }

        

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            amount = Convert.ToInt32(AmountTextBox.Text);
           // MessageBox.Show(narration);
            // amount = Int32.Parse(AmountTextBox.ToString());
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            VoucherControl voucherControl = new VoucherControl();
            voucherControl.InsertIntoVoucherControl(paidBy, transactionType, amount, narration, date, employeeID);
            MessageBox.Show("Your transaction has been added");
            GetStuff();
        }
    }
}
