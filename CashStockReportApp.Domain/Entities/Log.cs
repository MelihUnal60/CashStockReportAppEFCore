using CashStockReportApp.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.Domain.Entities
{
    public sealed class Log:BaseEntity
    {
        public int OrderId { get; set; }

        public DateTime CreatedTime { get; set; }

        public string CreatedUser { get; set; }




    }
}
