using CashStockReportApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.App
{
    public interface ICategoryService 
    {
        void Create(string name);
        
        bool Delete(int catId);

        Category Update(int catId, string newCategoryName);
    }
}
