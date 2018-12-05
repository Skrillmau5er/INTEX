using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    [Table("Samples")]
    public class Samples
    {
        [Key]
        public int LTNumber { get; set; }
        public String CompoundName { get; set; }

        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}