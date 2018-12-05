using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    [Table("Test")]
    public class Test
    {
        [Key]
        public int TestID { get; set; }
        public String Type { get; set; }
        public String Description { get; set; }

        public virtual ICollection<AssayTest> AssayTests { get; set; }
        public virtual ICollection<TestMaterial> TestMaterials { get; set; }
    }
}