using System.Web.Mvc;
using HiQo.StaffManagement.WEB.Error_Handler;

namespace HiQo.StaffManagement.WEB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleAllErrorAttribute());
        }
    }
}
