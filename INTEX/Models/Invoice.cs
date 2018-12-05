using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    [Table("Invoice")]
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public double TotalPrice { get; set; }
        public float EmployeeDiscount { get; set; }
        public double FinalPrice { get; set; }
        public DateTime EarlyPaymentDate { get; set; }
        public float EarlyPaymentDiscount { get; set; }
        public DateTime InvoiceDueDate { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime ReceivedPaymentDate { get; set; }
    }
}