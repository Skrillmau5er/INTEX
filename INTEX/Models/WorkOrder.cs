using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    [Table("WorkOrder")]
    public class WorkOrder
    {
        [Key]
        public int WorkOrderID { get; set; }
        public DateTime DueDate { get; set; }
        public String SummaryReport { get; set; }

        [Display(Name = "OrderID")]
        public virtual int OrderID { get; set; }
        public virtual Orders Order { get; set; }

        [Display(Name = "StatusID")]
        public virtual int StatusID { get; set; }
        public virtual Status Status { get; set; }

        [Display(Name = "LTNumber")]
        public virtual int LTNumber { get; set; }
        public virtual Compound Compound { get; set; }

    }
}