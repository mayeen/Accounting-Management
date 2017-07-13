using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingManagement.Model;
using System.Data;

namespace AccountingManagement.Controller
{
    class AccountControl
    {
        
        public static DataTable TransactionSelectedDataControl(int a)
        {
            int selectedIndex = a;
            DataTable dt= AccountQuery.TransactionTable(selectedIndex);
            return dt;
        }
        public static DataTable PaidByDataControl()
        {
            
            DataTable dt = AccountQuery.AccountTable();

            return dt;
        }

        public static DataTable TransactionTypeDataControl()
        {

            DataTable dt = AccountQuery.AccountTable();

            return dt;
        }
    }
}
