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
        

        private readonly IRepository<Category> _repositoryCategory;

        public CategoryService()
        {
            _repositoryCategory = IOCContainer.Resolve<IRepository<Category>>();
        }

        public void Create(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Lütfen kategori adını boş bırakmayınız!!");
            Category category = new Category();
            category.CategoryName = name;

            _repositoryCategory.Add(category);
            

        }

        public bool Delete(int catId)
        {
            
            return _repositoryCategory.Remove(catId);
            
        }

        public void Update(int catId, string newCategoryName)
        {
            var category = new Category();
            category.Id = catId;
            category.CategoryName=newCategoryName;
            _repositoryCategory.Add(category);
        }

        void ICategoryService.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
