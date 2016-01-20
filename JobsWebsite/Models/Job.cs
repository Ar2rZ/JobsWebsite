using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobsWebsite.Models
{
    //Job details
    public class Job
    {
        public int JobId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateEntered { get; set; }
        public int Hours { get; set; }
        public string SolaryRange { get; set; }
        public string Status { get; set; }
        public string Technology { get; set; }
        public string Location { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}