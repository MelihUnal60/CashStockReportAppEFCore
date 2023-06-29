using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.App
{
    public interface ICustomerService
    {
        void Create(string name, string surname, string phone);
    }
}
