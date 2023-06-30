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
    public class InvoiceService : IInvoiceService
    {
        private readonly IRepository<Invoice> _invoiceRepository;

        public InvoiceService()
        {
            _invoiceRepository = IOCContainer.Resolve<IRepository<Invoice>>();
        }


        public void Create(decimal invAmt, int cusId, int cshId, int invOrdId)
        {
            Invoice invoice = new Invoice();
            invoice.InvoiceAmount = invAmt;
            invoice.CashierId = cshId;
            invoice.CustomerId = cusId;
            invoice.InvoiceOfOrderId = invOrdId;
            invoice.CreatedDate = DateTime.Now;
            invoice.CreatedUser = "Melih";

            _invoiceRepository.Add(invoice);
        }
    }
}
