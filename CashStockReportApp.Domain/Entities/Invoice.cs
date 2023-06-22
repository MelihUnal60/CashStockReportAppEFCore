using CashStockReportApp.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.Domain.Entities
{
    public sealed class Invoice:AuditEntity
    {
        public decimal InvoiceAmount { get; set; }

        public int CustomerId { get; set; }

        public int CashierId { get; set; }

        public int InvoiceOfOrderId { get; set; }

        public Cashier Cashier { get; set; } //Navigation Property

        public Order Order { get; set; }

    }
}
