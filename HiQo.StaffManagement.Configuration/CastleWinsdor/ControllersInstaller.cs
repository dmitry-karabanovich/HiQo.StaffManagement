using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace HiQo.StaffManagement.Configuration.CastleWinsdor
{
    public class ControllersInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //container.Register(AllTypes.FromAssemblyNamed("HiQo.StaffManagement.WEB")
            //    .Pick().If(t => t.Name.EndsWith("Controller"))
            //    .Configure(configurer => configurer.Named(configurer.Implementation.Name))
            //    .LifestylePerWebRequest());

            container.Register(Classes.FromAssemblyNamed("HiQo.StaffManagement.Web")
                .BasedOn<IController>()
                .LifestylePerWebRequest()
                .Configure(x => x.Named(x.Implementation.FullName)));
        }
    }
}
