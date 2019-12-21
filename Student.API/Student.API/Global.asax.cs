using Student.API.App_Start;
using System.Web.Http;

namespace Student.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutofacInitializer.Initialize(GlobalConfiguration.Configuration);
        }
    }
}
