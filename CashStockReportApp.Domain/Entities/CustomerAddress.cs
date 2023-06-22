using CashStockReportApp.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.Domain.Entities
{
    public sealed class CustomerAddress:BaseEntity
    {
        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public int AdressOfCustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
