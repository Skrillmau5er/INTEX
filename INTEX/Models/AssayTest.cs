using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    [Table("AssayTest")]
    public class AssayTest
    {
        [Key, Column(Order = 1)]
        public int TestTubeNumber { get; set; }
        [Key, Column(Order = 2)]
        public int LTNumber { get; set; }
        [Key, Column(Order = 3)]
        public int AssayID { get; set; }
        public DateTime StartDatetime { get; set; }
        public DateTime FinishDatetime { get; set; }
        public String QuantDataLink { get; set; }
        public String QualDataLink { get; set; }
        public int EmployeeID { get; set; }
        public float Hours { get; set; }
        public String Active { get; set; }

        [Display(Name = "TestID")]
        public virtual int TestID { get; set; }
        public virtual Test Test { get; set; }
    }
}