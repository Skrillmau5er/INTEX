using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    [Table("Assay")]
    public class Assay
    {
        [Key]
        public int AssayID { get; set; }
        public String Type { get; set; }
        public String Description { get; set; }
        public String Protocol { get; set; }
        public int DayEstimate { get; set; }

        public virtual ICollection<AssayTest> AssayTests { get; set; }
    }
}