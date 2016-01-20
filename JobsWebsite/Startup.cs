using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobsWebsite.Startup))]
namespace JobsWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
