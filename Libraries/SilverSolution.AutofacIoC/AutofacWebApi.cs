using Autofac;
using Autofac.Integration.WebApi;
using SilverSolution.Business.Services.Concrete;
using SilverSolution.Core.DependencyResolve;
using SilverSolution.EFCodeFirst.Repositories;
using System.Reflection;
using System.Web.Http;

namespace SilverSolution.AutofacIoC
{
    public class AutofacWebApi : IDependencyResolve
    {

        private readonly Assembly _assembly;
        private readonly HttpConfiguration _httpConfiguration;
        public AutofacWebApi(Assembly assembly, HttpConfiguration httpConfiguration)
        {
            _assembly = assembly;
            _httpConfiguration = httpConfiguration;
        }

        public void Bootstrap()
        {
           
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(_assembly);
            //builder.RegisterType<CategoryService>().As<ICustomerService>().InstancePerRequest();
            //builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().InstancePerRequest();

            builder.RegisterAssemblyTypes(typeof(CategoryService).Assembly)
              .Where(t => t.Name.EndsWith("Service"))
              .AsImplementedInterfaces().InstancePerRequest();


            builder.RegisterAssemblyTypes(typeof(CategoryRepository).Assembly)
             .Where(t => t.Name.EndsWith("Repository"))
             .AsImplementedInterfaces().InstancePerRequest();


            var container = builder.Build();
            _httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
