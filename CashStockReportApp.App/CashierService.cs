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
    public class CashierService : ICashierService
    {
        public void Create(string name, string surname, string gender)
        {
            var repo = IOCContainer.Resolve<IRepository<Cashier>>();

            Cashier cashier = new Cashier()
            {
                CashierName = name,
                CashierSurname = surname,
                Gender = gender,
                HireDate = DateTime.Now
            };
            repo.Add(cashier);
        }
    }
}
