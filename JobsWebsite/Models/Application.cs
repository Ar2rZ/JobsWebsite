using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobsWebsite.Models
{
    //Application details
    public class Application
    {
        public int UserId { get; set; }
        public int JobId { get; set; }
        public string Status { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationNumber { get; set; }
        public string CompanyAccount { get; set; }
    }
}