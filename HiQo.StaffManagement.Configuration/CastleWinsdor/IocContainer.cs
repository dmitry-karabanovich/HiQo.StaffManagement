using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.Repositories;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Services;
using HiQo.StaffManagement.Domain.Services.Interface;

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

        private static void InstallDependency(IWindsorContainer container)
        {
            container.Register(Component.For<IUserRepository>().ImplementedBy(typeof(UserRepository)).LifestylePerWebRequest());
            container.Register(Component.For<IRoleRepository>().ImplementedBy<RoleRepository>().LifestylePerWebRequest());
            container.Register(Component.For<IPositionRepository>().ImplementedBy<PositionRepository>().LifestylePerWebRequest());
            container.Register(Component.For<IPositionLevelRepository>().ImplementedBy<PositionLevelRepository>().LifestylePerWebRequest());
            container.Register(Component.For<IDepartmentRepository>().ImplementedBy<DepartmentRepository>().LifestylePerWebRequest());
            container.Register(Component.For<ICategoryRepository>().ImplementedBy<CategoryRepository>().LifestylePerWebRequest());

            container.Register(Component.For<IUserService>().ImplementedBy(typeof(UserService)).LifestylePerWebRequest());
            container.Register(Component.For<IPositionService>().ImplementedBy<PositionService>().LifestylePerWebRequest());
            container.Register(Component.For<IPositionLevelService>().ImplementedBy<PositionLevelService>().LifestylePerWebRequest());
            container.Register(Component.For<IDepartmentService>().ImplementedBy<DepartmentService>().LifestylePerWebRequest());
            container.Register(Component.For<ICategoryService>().ImplementedBy<CategoryService>().LifestylePerWebRequest());
            container.Register(Component.For<IUpsertUserService>().ImplementedBy<UpsertUserService>().LifestylePerWebRequest());

            container.Register(Component.For<CompanyContext>().LifestylePerWebRequest());
        }
    }
}
