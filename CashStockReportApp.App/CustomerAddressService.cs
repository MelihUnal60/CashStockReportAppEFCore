using CashStockReportApp.Domain.Entities;
using CashStockReportApp.Domain.Interfaces;
using CashStockReportApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.App
{
    public class CustomerAddressService : ICustomerAddressService
    {
        private readonly IRepository<CustomerAddress> _customerAddressRepository;

        public CustomerAddressService()
        {
            _customerAddressRepository = IOCContainer.Resolve<IRepository<CustomerAddress>>();
        }

        public void Create(string address, string city, string region, int adressOfCustomerId)
        {
            CustomerAddress customerAddress = new CustomerAddress();
            customerAddress.Address = address;
            customerAddress.City = city;
            customerAddress.Region = region;
            customerAddress.AdressOfCustomerId = adressOfCustomerId;
        }
    }
}
