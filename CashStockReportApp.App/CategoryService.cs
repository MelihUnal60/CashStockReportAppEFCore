using CashStockReportApp.Domain.Entities;
using CashStockReportApp.Domain.Interfaces;
using CashStockReportApp.Infrastructure;
using CashStockReportApp.Infrastructure.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.App
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryService()
        {
            _categoryRepository = IOCContainer.Resolve<IRepository<Category>>();
        }

        public void Create(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Lütfen kategori adını boş bırakmayınız!!");

            var oldCategory = _categoryRepository.GetList().FirstOrDefault(c = c => c.Name == name);
            if (oldCategory != null)
                return;

            Category category = new Category();
            category.CategoryName = name;
            _categoryRepository.Add(category);
            

        }
    }
}
