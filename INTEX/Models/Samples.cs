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
        [Key, Column(Order = 1)]
        public int SequenceCode { get; set; }
        [Key, Column(Order = 2)]
        public int LTNumber { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime ReceivedDate { get; set; }
        public String Appearance { get; set; }
        public float MolecularMass { get; set; }
        public float MTD { get; set; }
        public float ClientWeight { get; set; }
        public float ActualWeight { get; set; }

        [Display(Name = "AssayID")]
        public virtual int AssayID { get; set; }
        public virtual Assay Assay { get; set; }
    }
}