using CashStockReportApp.Domain.Entities.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.Domain.Entities
{
    public sealed class Category:BaseEntity
    {
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
