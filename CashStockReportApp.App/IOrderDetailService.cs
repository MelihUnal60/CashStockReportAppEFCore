using CashStockReportApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.App
{
    public interface IOrderDetailService
    {
        void Create(int ordId, int prdId, decimal unitPrice, short qty);
    }
}
