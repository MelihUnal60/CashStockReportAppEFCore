using CashStockReportApp.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.Domain.Entities
{
    public sealed class Order:AuditEntity
    {


        public DateTime OrderDate { get; set; }

        public decimal TotalPrice { get; set; }

        public string ShipCompany { get; set; }

        public string ShipCity { get; set; }

        public Invoice OrderInvoice { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
