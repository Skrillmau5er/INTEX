using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal QuotedPrice { get; set; }
        public decimal? ActualPrice { get; set; }
        public string OrderDetails { get; set; }

        [Display(Name = "CustomerID")]
        public  virtual int CustomerID { get; set; }
        public  virtual Customer Customer { get; set; }

        [Display(Name = "EmployeeID")]
        public virtual int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }

        [Display(Name = "InvoiceID")]
        public virtual int? InvoiceID { get; set; }
        public virtual Invoice Invoice { get; set; }

        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}