using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JobsWebsite.Models
{
    //DataBase context class CRUD functionality
    public class DatabaseContext : DbContext
    {
        public DbSet<Application> Applications { get; set; }
        public DbSet<CustomerCompany> CustomerCompanies{ get; set; }
        public DbSet<CustomerPersonal> CustomerPersonals { get; set; }
        public DbSet<Job> Jobs { get; set; }

    }
}