using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    [Table("PaymentInfo")]
    public class PaymentInfo
    {
        [Key]
        public int PaymentInfoID { get; set; }
        public String BillingAddress { get; set; }
        public int CreditCardNo { get; set; }

        [Display(Name = "CustomerID")]
        public virtual int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

    }
}