using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingManagement.Model
{
    public class AccountQuery
    {
        public static DataTable AccountTable()
        {
            using (AccountingEntity c = new AccountingEntity())
            {
                List<Account> usepurposes = c.Accounts.ToList();              
                DataTable dt = new DataTable();
                dt.Columns.Add("id");
                dt.Columns.Add("name");
                foreach (Account usepurpose in usepurposes)
                {
                   // if (usepurpose.Type==4)
                    dt.Rows.Add(usepurpose.Code, usepurpose.Name);
                }
                return dt;
            }

        }

        public static DataTable TransactionTable(int x)
        {
            int code = x;

            using (AccountingEntity c = new AccountingEntity())

            {
                List<Account> usepurposes = c.Accounts.ToList();
                Account account = new Account();

                DataTable dt = new DataTable();
                dt.Columns.Add("id");
                dt.Columns.Add("name");
                var query = from ac in c.Accounts
                            where ac.Code == code
                            select ac.Type;
                int type = query.FirstOrDefault();
               

                //var queryToList = query.ToList();
                //int type= Convert.ToInt32( query);

                foreach (Account usepurpose in usepurposes)
                {

                    if (usepurpose.Type != type )
                    {
                        dt.Rows.Add(usepurpose.Code, usepurpose.Name);
                    }
                }
                return dt;
            }

        }        



        public void AccountDataEntry()
        {
        using (AccountingEntity context = new AccountingEntity())
            {
                int i = 4;
                context.Accounts.Add(new Account { Code = 110000+i, Name="BANK ACCOUNT", Type= 3 });
                i = i + 2;
                context.Accounts.Add(new Account { Code = 110000 + i, Name = "ADVERTISEMENT AND PUBLICITY EXP", Type = 1 });
                i = i + 2;
                context.Accounts.Add(new Account { Code = 110000 + i, Name = "GENERAL EXPENSES", Type = 1 });
                i = i + 2;
                context.Accounts.Add(new Account { Code = 110000 + i, Name = "REPAIR & MAINTENANCE EXPENSES ACCOUNT", Type = 1 });
                i = i + 2;
                context.Accounts.Add(new Account { Code = 110000 + i, Name = "MISCELLANEOUS EXPENSES", Type = 1 });
                i = i + 2;
                context.Accounts.Add(new Account { Code = 110000 + i, Name = "SALARY ACCOUNT", Type = 2 });
                i = i + 2;
                context.Accounts.Add(new Account { Code = 110000 + i, Name = "WAGES ACCOUNT", Type = 1 });
                i = i + 2;
                context.Accounts.Add(new Account { Code = 110000 + i, Name = "INCOME TAX ACCOUNT", Type = 4 });
                i = i + 2;
                context.Accounts.Add(new Account { Code = 110000 + i, Name = "RENT ACCOUNT", Type = 1 });
                i = i + 2;
                context.Accounts.Add(new Account { Code = 110000 + i, Name = "PURCHASE ACCOUNT", Type = 1 });
                i = i + 2;
                context.Accounts.Add(new Account { Code = 110000 + i, Name = "LOANS TO STAFF", Type = 4 });
                i = i + 2;
                context.Accounts.Add(new Account { Code = 110000 + i, Name = "FURNITURE ACCOUNT", Type = 3 });
                



                context.SaveChanges();
            }
        }
    

    }
}
