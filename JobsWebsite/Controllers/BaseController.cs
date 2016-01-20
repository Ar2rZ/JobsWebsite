using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobsWebsite.Helper;


namespace JobsWebsite.Controllers
{
    public class BaseController : Controller
    {
        //Localisation http://www.c-sharpcorner.com/UploadFile/4d9083/globalization-and-localization-in-Asp-Net-mvc-4/
        protected override void ExecuteCore()
        {
            int culture;
            if (Session?["CurrentCulture"] == null)
            {
                int.TryParse(System.Configuration.ConfigurationManager.AppSettings["Culture"], out culture);
                var httpSessionStateBase = Session;
                if (httpSessionStateBase != null) httpSessionStateBase["CurrentCulture"] = culture;
            }
            else
            {
                culture = (int)Session["CurrentCulture"];
            }
            // calling CultureHelper class properties for setting  
            CultureHelper.CurrentCulture = culture;

            base.ExecuteCore();
        }

        protected override bool DisableAsyncSupport => true;
    }
}