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
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;

        public OrderService()
            {
                _orderRepository = IOCContainer.Resolve<IRepository<Order>>();
            }

        public void Create(decimal price, string shipCompany, string city)
        {
            Order order = new Order();
            order.CreatedUser = "User1";
            order.ShipCompany = shipCompany;
            order.OrderDate = DateTime.Now;
            order.CreatedDate = DateTime.Now;
            order.TotalPrice = price;
            order.ShipCity = city;

            _orderRepository.Add(order);
        }
    }
}
