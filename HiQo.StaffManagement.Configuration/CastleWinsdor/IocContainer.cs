using System.Web.Mvc;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace HiQo.StaffManagement.Configuration.CastleWinsdor
{
    public class IocContainer
    {
        private static IWindsorContainer _container;

        public static void SetUp(string assembly)
        {
            _container = new WindsorContainer();

            var controllersInstaller = new ControllersInstaller(assembly);
            controllersInstaller.Install(_container,null);

            var resolveInstaller = new DependencyResolverInstaller();
            resolveInstaller.Install(_container,null);
          
            var controllerFactory = new WindsorControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);

        }
    }
}

//_container = new WindsorContainer();
//var s = FromAssembly.Named("HiQo.StaffManagement.Configuration");
//_container = _container.Install(s);
