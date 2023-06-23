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

        private readonly IRepository<Product> _productRepository;

        public ProductService()
        {
            _productRepository = IOCContainer.Resolve<IRepository<Product>>();
        }


        public void Create(string name, int amount, int categoryId, decimal unitPrice)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Lütfen ürün adını boş bırakmayınız!!");
            if(amount < 0)
                throw new ArgumentNullException("Lütfen miktarı sıfırdan büyük giriniz!!");

            Product product = new Product()
            {
                Name = name,
                Stock = amount,
                CategoryId = categoryId,
                Price = unitPrice
            };
            _productRepository.Add(product);

        }

        public bool Delete(int prdId)
        {
            return _productRepository.Remove(prdId);
        }

        public Product Update(int prdId, string newProductName, int newAmount, decimal newPrice)
        {
            var product = new Product();
            product.Id = prdId;
            product.Name = newProductName;
            product.Stock = newAmount;
            product.Price = newPrice;
            return _productRepository.Update(prdId, product);
        
        }

        
    }
}
