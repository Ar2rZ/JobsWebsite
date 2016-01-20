using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobsWebsite.Models
{
    //Personal customer details
    public class CustomerPersonal : Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CV { get; set; }
        public string Expertise { get; set; }
        public string JobLocation { get; set; }
    }
}