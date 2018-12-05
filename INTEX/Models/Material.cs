using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    [Table("Material")]
    public class Material
    {
        [Key]
        public int MaterialID { get; set; }
        public String MaterialName { get; set; }
        public String Description { get; set; }
        public double PricePerUnit { get; set; }

        public virtual ICollection<TestMaterial> TestMaterials { get; set; }
    }
}