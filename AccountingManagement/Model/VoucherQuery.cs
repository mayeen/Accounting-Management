using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingManagement.Model
{
    class VoucherQuery
    {
        public void InsertIntoVoucher(int paidBy, int transactionType,int amount,string narration,DateTime date, string employeeID)
        {
            using (AccountingEntity context = new AccountingEntity())
            {
                Voucher voucher = new Voucher
                {
                    Debit = paidBy,
                    Credit = transactionType,
                    Amount = amount,
                    Narration = narration,
                    VDate = date,
                    AuthenticationBy = employeeID,
                    PreparedBy = "A001"
                };
                context.Vouchers.Add(voucher);
              //  MessageBox.Show(voucher.AuthenticationBy.ToString());
                context.SaveChanges();
            }

        }
        public void UpdateIntoVoucher(int VoucherNo, int paidBy, int transactionType, int amount, string narration, DateTime date, string employeeID)
        {
            using (AccountingEntity context = new AccountingEntity())
            {
                Voucher voucher = context.Vouchers.FirstOrDefault(r => r.VNo==VoucherNo);
                voucher.Debit = transactionType;
                voucher.Credit = paidBy;
                voucher.Amount = amount;
                voucher.Narration = narration;
                voucher.VDate = DateTime.Now;
                voucher.AuthenticationBy = employeeID;
                context.SaveChanges();

            }
        }
        public int returnVoucherNo()
        {
            using (AccountingEntity context = new AccountingEntity())
            {

                int id = context.Vouchers.Max(r => r.VNo);
                return id + 1;
            }

        }
        public dynamic DisplayVoucherData()
        {
            
             
            using (AccountingEntity context = new AccountingEntity())
            {
                var results = from v in context.Vouchers
                              join em in context.Employees
                              on v.AuthenticationBy equals em.Emp_ID
                              join accDebit in context.Accounts
                              on v.Debit equals accDebit.Code
                              join accCredit in context.Accounts
                              on v.Credit equals accCredit.Code

                              select new
                              {
                                  voucherNo = v.VNo,
                                  Debit = accDebit.Name,
                                  Amount = v.Amount,
                                  Credit = accCredit.Name,
                                  Date = v.VDate,
                                  Narration = v.Narration,
                                  Authentication = em.FName
                                  //State = r.StateNavigationProperty.StateLabel, //If FK
                                  //State = _context.State.First(state => state.StateId == r.StateId), //If Not FK
                                  //HostAddress = r.ServerReference.Value.HostAddress,
                                  //TimeStamp = r.TimeStamp
                                  
                              };
                var resultToList = results.ToList();
                return resultToList;
            }
                 
        }
    }
}
