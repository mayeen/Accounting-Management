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

namespace AccountingManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
       

        public void AddAuthorisedByComboBox()
        {
            DataTable dt = AccountQuery.AccountTable();
            AccountComboBox.ValueMember = dt.Columns[0].ColumnName;
            AccountComboBox.DisplayMember = dt.Columns[1].ColumnName;
            AccountComboBox.DataSource = dt;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToLongDateString();
            AccountQuery ac = new AccountQuery();

            AddAuthorisedByComboBox();
           // here I have populated Account Table with data that will work only one time 
            //AccountQuery acc = new AccountQuery();
            //acc.AccountDataEntry();
            
            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AccountingEntity"].ConnectionString);
            //SqlCommand cmd = new SqlCommand("Select * from AccountType", con);
            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //BindingSource source = new BindingSource();
            //source.DataSource = reader;
            //dataGridView1.DataSource = source;
            //con.Close();

            using (AccountingEntity context = new AccountingEntity())
            {
                //AccountType accountType = new AccountType
                //{
                //    Category = "5th category"

                //};
                //context.AccountTypes.Add(accountType);
                //context.SaveChanges();
                //  AccountType indexDelete = context.AccountTypes.FirstOrDefault(;
                
                
                //var display = from b in context.AccountTypes
                //              select b;
                //BindingSource source = new BindingSource();
                

                //source.DataSource = display.ToList();  //error ache 

                //dataGridView1.DataSource = source;

                //context.Employees.Add(new Employee { Emp_ID="A002", FName="Nazmul ",MInit=" aka",LName="Hasan",Address="Modhubag",PhoneNo=01523114992,Super_ID="A001"});
                //context.Employees.DefaultIfEmpty();
                //context.SaveChanges();
                //var display = from b in context.Employees
                //              select b;
                //BindingSource source = new BindingSource();
                //source.DataSource = display.ToList();
                


            }

        }

        private void AuthorisedByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
