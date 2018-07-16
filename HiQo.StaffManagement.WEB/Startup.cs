using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HiQo.StaffManagement.WEB.Startup))]
namespace HiQo.StaffManagement.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
