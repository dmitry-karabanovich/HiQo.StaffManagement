using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.Repositories;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Services;
using HiQo.StaffManagement.Domain.Services.Interface;

namespace HiQo.StaffManagement.Configuration.CastleWinsdor
{
    public class DependencyResolverInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
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

            container.Register(Component.For<CompanyContext>().LifestylePerWebRequest());
        }
    }
}
