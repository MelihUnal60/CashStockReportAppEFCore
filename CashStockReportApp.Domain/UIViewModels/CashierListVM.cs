using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.Domain.UIViewModels
{
    public class CashierListVM
    {
        public string KasiyerAdi { get; set; }

        public string KasiyerSoyadi { get; set; }

        public DateTime IsBasiTarihi { get; set; }

        public int FaturaAdedi { get; set; }
    }
}
