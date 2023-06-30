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
    public class OrderDetailService : IOrderDetailService
    {
        private readonly OrderDetailService _orderDetailRepository; 

        public OrderDetailService()
        {
            _orderDetailRepository = IOCContainer.Resolve<OrderDetailService>();
        }

        public void Create(int ordId, int prdId, decimal unitPrice, short qty)
        {
            OrderDetail orderDetail = new OrderDetail();
            orderDetail.OrderId = ordId;
            orderDetail.ProductId = prdId;
            orderDetail.PricePerUnit = unitPrice;
            orderDetail.Qty = qty;

            _orderDetailRepository.Create(orderDetail.OrderId,orderDetail.ProductId,orderDetail.PricePerUnit,orderDetail.Qty);
        }
    }

    
}
