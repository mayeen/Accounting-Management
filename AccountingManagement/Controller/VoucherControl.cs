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
            public dynamic VoucherDataControl()
        {
            VoucherQuery voucherQuery = new VoucherQuery();
            var voucherData= voucherQuery.DisplayVoucherData();
            return voucherData;
        }
    }
}
