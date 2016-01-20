using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobsWebsite.Models
{
    //Company customer details
    public class CustomerCompany : Customer
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpiryMonth { get; set; }
        public DateTime ExpiryYear { get; set; }
        public int CCV { get; set; }
        public bool Premium { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime PaymentDue { get; set; }

    }
}
