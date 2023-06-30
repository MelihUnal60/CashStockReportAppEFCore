using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.App
{
    public interface ICustomerAddressService
    {
        void Create(string address, string city, string region, int adressOfCustomerId);
    }
}
