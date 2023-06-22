using CashStockReportApp.Domain.Entities;
using CashStockReportApp.Domain.Entities.Base;
using CashStockReportApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.Infrastructure.EFCore
{
    public class EFCoreRepository<T> : IRepository<T> where T : BaseEntity
    {

        private static List<T> list = new List<T>();

        public T Add(T entity)
        {
            list.Add(entity);
            return entity;
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetList(Func<T, bool> expression = null)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public T Update(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
