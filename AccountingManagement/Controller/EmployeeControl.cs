using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingManagement.Model;
using System.Data;

namespace AccountingManagement.Controller
{
    class EmployeeControl
    {
        public static DataTable EmployeeDataControl()
        {
            DataTable dt = EmployeeQuery.EmployeeTable();
            return dt;

        }
    }
}
