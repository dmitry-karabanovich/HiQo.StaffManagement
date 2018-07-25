using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using HiQo.StaffManagement.Configuration.AutoMapper;
using HiQo.StaffManagement.Configuration.AutoMapper.Profilers;

namespace HiQo.StaffManagement.WEB
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            AutoMappingConfig.ConfigureAutoMapping();
        }
    }
}
