using CashStockReportApp.Domain.Entities.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.Domain.Entities
{
    public sealed class Customer:BaseEntity
    {
        public string CustomerName { get; set; }

        public string CustomerSurname { get; set; }

        public string CustomerPhone { get; set; }

        public CustomerAddress Address { get; set; }
    }
}
