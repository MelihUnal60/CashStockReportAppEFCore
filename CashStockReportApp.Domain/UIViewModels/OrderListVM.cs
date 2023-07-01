using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.Domain.UIViewModels
{
    public class OrderListVM
    {
        public DateTime SiparisTarihi { get; set; }

        public int SiparisNo { get; set; }

        public decimal ToplamTutar { get; set; }

    }
}
