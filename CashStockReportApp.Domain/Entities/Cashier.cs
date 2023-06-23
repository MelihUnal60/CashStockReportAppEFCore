using CashStockReportApp.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.Domain.Entities
{
    public sealed class Cashier:BaseEntity
    {
        public string CashierName { get; set; }

        public string CashierSurname { get; set; }

        public string Gender { get; set; }

        public ICollection <Invoice> Invoices { get; set; }

        public DateTime? HireDate { get; set; }

        public DateTime? FireTime { get; set;}
    }
}
