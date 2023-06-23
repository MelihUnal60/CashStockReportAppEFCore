using CashStockReportApp.Domain.Entities;
using CashStockReportApp.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.App
{
    public interface ICashierService
    {
        void Create(string name, string surname, string gender);
       
    }
}
