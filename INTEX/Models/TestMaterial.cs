using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    [Table("TestMaterial")]
    public class TestMaterial
    {
        [Key, Column(Order = 1)]
        public int MaterialID { get; set; }
        [Key, Column(Order = 2)]
        public int TestID { get; set; }
        public int NumberOfUnits { get; set; }
        public double PricePerUnit { get; set; }
    }
}