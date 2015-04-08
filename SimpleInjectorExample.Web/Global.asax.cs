using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using SimpleInjectorExample.IOC;

namespace SimpleInjectorExample.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            DependencyResolver.SetResolver(SimpleInjectorContainer.RegisterServices());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
