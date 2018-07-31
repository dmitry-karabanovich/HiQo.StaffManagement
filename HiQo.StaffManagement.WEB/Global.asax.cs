using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using HiQo.StaffManagement.Configuration.AutoMapper;
using HiQo.StaffManagement.Configuration.CastleWinsdor;

namespace HiQo.StaffManagement.WEB
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes,Assembly.GetExecutingAssembly());
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMappingConfig.ConfigureAutoMapping();
            IocContainer.SetUp();
        }
    }
}
