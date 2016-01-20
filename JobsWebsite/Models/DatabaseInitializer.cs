using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JobsWebsite.Models
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
           var customerCompany = new List<CustomerCompany>
            {
                new CustomerCompany
                {
                    UserName = "ABCCompany",
                    CompanyName = "ABC Corportation",
                    Email = "abcco@mail.org",
                    LastLogin = DateTime.Now
                }
            };

            var customerPersonal= new List<CustomerPersonal>
            {
                new CustomerPersonal
                {
                    UserName = "JohnD",
                    LastName = "Doe",
                    FirstName = "John",
                    Email = "johndoe@mail.org",
                    LastLogin = DateTime.Now
                }
            };

            var application = new List<Application>
            {
                new Application
                {
                    UserId = 1,
                    JobId = 1,
                    CompanyAccount = "ABCCompany",
                    ApplicationNumber = 1
                }
            };

            var jobs = new List<Job>
            {
                new Job
                {
                    Title = "Developer",
                    SolaryRange = "35000-40000",
                    Technology = "IT",
                    Location = "Dublin 2"
                }
            };

            foreach (var appl in application)
            {
                context.Applications.Add(appl);
            }

            foreach (var cc in customerCompany)
            {
                context.CustomerCompanies.Add(cc);
            }

            foreach (var cp in customerPersonal)
            {
                context.CustomerPersonals.Add(cp);
            }

            foreach (var job in jobs)
            {
                context.Jobs.Add(job);
            }

            context.SaveChanges();
        }
    }
}