using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingManagement.Model;
using AccountingManagement.View;

namespace AccountingManagement.Controller
{
    class VoucherControl
    {
            public dynamic VoucherDataControl() // to show Voucher Table Data 
        {
            VoucherQuery voucherQuery = new VoucherQuery();
            var voucherData= voucherQuery.DisplayVoucherData();
            return voucherData;
        }
        public int getVoucherID(VoucherQuery v)  //to display voucher ID in the label
        {
            VoucherQuery e = v;
            int i = v.returnVoucherNo();
            return i;
        }
        public void InsertIntoVoucherControl(int paidBy, int transactionType, int amount, string narration, DateTime date, string employeeID)
        {
            Voucher voucher = new Voucher()
            {
                Credit = paidBy,
                Debit = transactionType,
                AuthenticationBy = employeeID,
                Amount = amount,
                Narration = narration,
                VDate = date
            };
            VoucherQuery voucherQuery = new VoucherQuery();
            voucherQuery.InsertIntoVoucher(paidBy, transactionType, amount, narration, date, employeeID);

        }
        public void UpdateIntoVoucherControl(int voucherNo, int paidBy, int transactionType, int amount, string narration, DateTime date, string employeeID)
        {
            Voucher voucher = new Voucher()
            { 
                VNo=voucherNo,
                Credit = paidBy,
                Debit = transactionType,
                AuthenticationBy = employeeID,
                Amount = amount,
                Narration = narration,
                VDate = date
            };
            VoucherQuery voucherQuery = new VoucherQuery();
            voucherQuery.UpdateIntoVoucher(voucherNo, paidBy, transactionType, amount, narration, date, employeeID);

        }

    }
}
