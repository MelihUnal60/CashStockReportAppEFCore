using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.App
{
    public interface IInvoiceService
    {
        void Create(decimal invAmt, int cusId, int cshId, int invOrdId);
    }
}
