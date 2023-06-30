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
    public class AppServiceConfigurations
    {
        public static void RegisterAllService()
        {
            //IOCContainer.Register<IRepository<Category>>(ServiceMethod);
            IOCContainer.Register<IRepository<Category>>(() => new EFCoreRepository<Category>());
            IOCContainer.Register<ICategoryService>(() => new CategoryService());
            IOCContainer.Register<IRepository<Product>>(() => new EFCoreRepository<Product>());
            IOCContainer.Register<IProductService>(() => new ProductService());
            IOCContainer.Register<IRepository<Cashier>>(() => new EFCoreRepository<Cashier>());
            IOCContainer.Register<ICashierService>(() => new CashierService());
            IOCContainer.Register<IRepository<Customer>>(() => new EFCoreRepository<Customer>());
            IOCContainer.Register<ICustomerService>(() => new CustomerService());
            IOCContainer.Register<IRepository<Order>>(() => new EFCoreRepository<Order>());
            IOCContainer.Register<IOrderService>(() => new OrderService());
            IOCContainer.Register<IRepository<Invoice>>(() => new EFCoreRepository<Invoice>());
            IOCContainer.Register<IInvoiceService>(() => new InvoiceService());
            IOCContainer.Register<IRepository<Log>>(() => new EFCoreRepository<Log>());
            IOCContainer.Register<ILogService>(() => new LogService());
            IOCContainer.Register<IRepository<CustomerAddress>>(() => new EFCoreRepository<CustomerAddress>());
            IOCContainer.Register<ICustomerAddressService>(() => new CustomerAddressService());

        }

       
    }
}
