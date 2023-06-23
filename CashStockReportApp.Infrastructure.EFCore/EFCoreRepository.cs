using CashStockReportApp.Domain.Entities;
using CashStockReportApp.Domain.Entities.Base;
using CashStockReportApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.Infrastructure.EFCore
{
    public class EFCoreRepository<T> : IRepository<T> where T : BaseEntity
    {

        private static List<T> list = new List<T>();

        private static void LoadListFromDb()
        {
            
        }

        public T Add(T entity)
        {
            list.Add(entity);
            return entity;
        }

        public T GetById(int id)
        {
            LoadListFromDb();
            var entity = list.FirstOrDefault(x => x.Id == id);
            return entity;
        }

        public ICollection<T> GetList(Func<T, bool> expression = null)
        {
            LoadListFromDb();

            return expression == null ? list : list.Where(expression).ToList();
        }

        public bool Remove(int id)
        {
            LoadListFromDb();
            var deletedEntity = list.FirstOrDefault((x) => x.Id == id);
            if (deletedEntity != null) 
            {
                list.Remove(deletedEntity);
            }
            return false;
        }

        public T Update(int id, T entity)
        {
           if(id!=entity.Id)
                throw new ArgumentException("ID değerleri uyuşmuyor!!");

           var updated = list.FirstOrDefault((x) => x.Id == id);
            if (updated == null)
                throw new ArgumentException("Varlık bulunamadı!!");
            list.Remove(updated);
            list.Add(entity);
            return entity;
        }
    }
}
