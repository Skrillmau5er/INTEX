using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public String CustFirstName { get; set; }
        public String CustLastName { get; set; }
        public String CustUserName { get; set; }
        public String CustPassword { get; set; }
        public String CustAddress { get; set; }
        public String CustCity { get; set; }
        public String CustState { get; set; }
        public String Country { get; set; }
        public String ZIP { get; set; }
        public String CustEmail { get; set; }
        public String CustPhone { get; set; }
    }
}