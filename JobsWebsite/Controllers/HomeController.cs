using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobsWebsite.Resources;
using JobsWebsite.Helper;
using JobsWebsite.Models;

namespace JobsWebsite.Controllers
{
    public class HomeController : BaseController
    {
        private DatabaseContext db = new DatabaseContext();
        public ActionResult Index()
        {
            var jobs = db.Jobs.ToList();
            return View(jobs);
        }

        public ActionResult About()
        {
            ViewBag.Message = Resource.Description_Page;//"Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = Resource.Contact_Page;//"Your contact page.";

            return View();
        }


        public ActionResult ChangeCulture(string lang, string returnUrl)
        {
            Session["Culture"] = new CultureInfo(lang);
            return Redirect(returnUrl);
        }

        public ActionResult ChangeCurrentCulture(int id)
        {
            //  
            // Change the current culture for this user.  
            //  
            CultureHelper.CurrentCulture = id;
            //  
            // Cache the new current culture into the user HTTP session.   
            //  
            Session["CurrentCulture"] = id;
            //  
            // Redirect to the same page from where the request was made!   
            //  
            return Redirect(Request.UrlReferrer.ToString());
        }
        //public ActionResult ChangeCurrentCulture(int id)
        //    {
        //        //  
        //        // Change the current culture for this user.  
        //        //  
        //        CultureHelper.CurrentCulture = id;
        //        //  
        //        // Cache the new current culture into the user HTTP session.   
        //        //  
        //        Session["Culture"] = id;
        //        //  
        //        // Redirect to the same page from where the request was made!   
        //        //  
        //        return Redirect(Request.UrlReferrer.ToString());
        //    }

    }
}