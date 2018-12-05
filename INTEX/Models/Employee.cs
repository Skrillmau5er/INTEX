using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    [Table("Emloyee")]
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public String EmpFirstName { get; set; }
        public String EmpLastName { get; set; }
        public String EmpUserName { get; set; }
        public String EmpPassword { get; set; }
        public String EmpAddress { get; set; }
        public String EmpCity { get; set; }
        public String EmpState { get; set; }
        public String Country { get; set; }
        public String ZIP { get; set; }
        public String OfficeCity { get; set; }
        public double HourlyWage { get; set; }
    }
}