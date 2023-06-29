using CashStockReportApp.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.Domain.Entities
{
    public sealed class Product:BaseEntity
    {
        //[StringLength(128)]
        //[Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        public int Stock { get; set; }

        //[ForeingKey("Category")] Data annotation ile yapsaydık bu şekilde yapacaktık fakat mimari yapıya aykırı

        public int? CategoryId { get; set; }

        public decimal Price { get; set; }

        public Category Category { get; set; }  //Navigation property

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
