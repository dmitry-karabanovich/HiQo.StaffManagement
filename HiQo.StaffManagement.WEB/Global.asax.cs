using System;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using HiQo.StaffManagement.Configuration.AutoMapper;
using HiQo.StaffManagement.Configuration.CastleWinsdor;
using HiQo.StaffManagement.WEB.Error_Handler;

namespace HiQo.StaffManagement.WEB
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes, Assembly.GetExecutingAssembly());
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMappingConfig.ConfigureAutoMapping();
            IocContainer.SetUp(Assembly.GetExecutingAssembly().GetName().Name);
        }

        //protected void Application_Error(object sender, EventArgs e)
        //{
        //    var exception = Server.GetLastError();
        //    Response.Clear();

        //    var httpException = exception as HttpException;

        //    if (httpException != null)
        //    {
        //        string action;

        //        switch (httpException.GetHttpCode())
        //        {
        //            case 404:
        //                action = "HttpError404";
        //                break;
        //            case 500:
        //                action = "HttpError500";
        //                break;
        //            default:
        //                action = "General";
        //                break;
        //        }

        //        Server.ClearError();

        //        Response.Redirect($"~/Error/{action}/?message={exception.Message}");
        //    }
        //}
    }
}
