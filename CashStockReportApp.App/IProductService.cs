using CashStockReportApp.Domain.Entities;
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

        bool Delete (int prdId);

        Product Update(int prdId, string newProductName, int newAmount, decimal newPrice);
    }
}
