using CashStockReportApp.Domain.Entities;
using CashStockReportApp.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Add (T entity);

        bool Remove (T entity);
        bool Remove(int catId);
        T Update (int id,T entity);

    }
}
