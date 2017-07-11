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

        public void DisplayVoucherData()
        {
            
        }
    }
}
