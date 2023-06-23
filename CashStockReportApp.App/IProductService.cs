using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.App
{
    public interface IProductService
    {
        void Create(string name, int amount, int categoryId, decimal unitPrice);
    }
}
