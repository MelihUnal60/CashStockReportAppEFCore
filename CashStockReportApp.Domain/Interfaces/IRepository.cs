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

        bool Remove (int id);

        T GetById (int id); //ID'ye göre istenilen tipi döner

        ICollection<T> GetList (Func<T,bool> expression = null); //istersek herşeyi, istersek link ile filtrelenmiş data döner.

        T Update (int id,T entity);

    }
}
