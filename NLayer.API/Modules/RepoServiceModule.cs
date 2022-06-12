using Autofac;
using NLayer.Data;
using NLayer.Data.Repositories;
using NLayer.Service;
using System.Reflection;
using Module = Autofac.Module;

namespace NLayer.API.Modules {
  public class RepoServiceModule : Module {

    protected override void Load(ContainerBuilder builder) {

      builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
      builder.RegisterGeneric(typeof(BaseService<>)).As(typeof(IService<>)).InstancePerLifetimeScope();

      builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();



      var apiAssembly = Assembly.GetExecutingAssembly();
      var repoAssembly = Assembly.GetAssembly(typeof(AppDBContext));

      builder.RegisterAssemblyTypes(apiAssembly, repoAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();


      builder.RegisterAssemblyTypes(apiAssembly, repoAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();


      // builder.RegisterType<ProductServiceWithCaching>().As<IProductService>();

    }
  }
} 