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
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _customerRepository;

        public CustomerService()
        {
            _customerRepository = IOCContainer.Resolve<IRepository<Customer>>();
        }

        public void Create(string name, string surname, string phone)
        {
            Customer customer = new Customer();
            customer.CustomerPhone = phone;
            customer.CustomerSurname = surname;
            customer.CustomerName = name;

            _customerRepository.Add(customer);
        }
    }
}
