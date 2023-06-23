using CashStockReportApp.Domain.Entities;
using CashStockReportApp.Domain.Interfaces;
using CashStockReportApp.Infrastructure;
using CashStockReportApp.Infrastructure.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.App
{
    public class ProductService : IProductService
    {
        public void Create(string name, int amount, int categoryId, decimal unitPrice)
        {
            var repo = IOCContainer.Resolve<IRepository<Product>>();

            Product product = new Product()
            {
                Name = name,
                Stock = amount,
                CategoryId = categoryId,
                Price = unitPrice
            };
            repo.Add(product);

        }
    }
}
