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
        
        void Delete(int id);

        void Update(int catId, string newCategoryName);
    }
}
