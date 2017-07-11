using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccountingManagement.Model
{
    class EmployeeQuery
    {
        public static DataTable EmployeeTable()
        {
            using (AccountingEntity c = new AccountingEntity())
            {
                List<Employee> usepurposes = c.Employees.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Emp_ID");
                dt.Columns.Add("First Name");
                foreach (Employee usepurpose in usepurposes)
                {
                    dt.Rows.Add(usepurpose.Emp_ID, usepurpose.FName);
                }
                return dt;
            }

        }
    }
}
