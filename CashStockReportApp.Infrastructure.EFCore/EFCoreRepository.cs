using CashStockReportApp.Domain.Entities;
using CashStockReportApp.Domain.Entities.Base;
using CashStockReportApp.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        APIDbContext context = new APIDbContext();

        

        public T Add(T entity)
        {
            context.Add(entity);
            context.SaveChanges();
            return entity;
        }

        

        public bool Remove(int id)
        {
            context.Remove(id);
            return false;
        }

        public bool Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public T Update(int id, T entity)
        {
           if(id!=entity.Id)
                throw new ArgumentException("ID değerleri uyuşmuyor!!");

           
            context.Update(entity);
            return entity;
        }
    }
}
