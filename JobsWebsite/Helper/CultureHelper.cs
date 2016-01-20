using System.Globalization;
using System.Threading;
using System.Web.SessionState;

namespace JobsWebsite.Helper
{
    public class CultureHelper
    {
        protected HttpSessionState Session;
        //private static string language;

        //constructor   
        public CultureHelper(HttpSessionState httpSessionState)
        {
            Session = httpSessionState;
        }
        // Properties  
        public static int CurrentCulture
        {
            get
            {
                if (Thread.CurrentThread.CurrentUICulture.Name == "en")
                {
                    return 0;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "ru")
                {
                    return 1;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "mr-IN")
                {
                    return 2;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "ar-SA")
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                //if (HttpContext.Current.Request.UserLanguages != null)
                //{
                //    //Set the Language.
                //    language = HttpContext.Current.Request.UserLanguages[0];
                //}

                if (value == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                }
                else if (value == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru");
                }
                else if (value == 2)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("mr-IN");
                }
                else if (value == 3)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-SA");
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
                }

                // Thread.CurrentThread.CurrentCulture = new CultureInfo(language); //Thread.CurrentThread.CurrentUICulture;
                Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture;

            }
        }
    }
}