using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobsWebsite.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool AccountStatus { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public bool EmailNotification { get; set; }
    }
}