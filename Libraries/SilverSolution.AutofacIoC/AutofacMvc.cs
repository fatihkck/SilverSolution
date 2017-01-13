using Autofac;
using Autofac.Integration.Mvc;
using SilverSolution.Business.Services.Abstract;
using SilverSolution.Business.Services.Concrete;
using SilverSolution.Core.DependencyResolve;
using SilverSolution.EFCodeFirst.Repositories;
using System;
using System.Reflection;
using System.Web.Mvc;

namespace SilverSolution.AutofacIoC
{
    public class AutofacMvc : IDependencyResolve
    {
        private readonly Assembly _assembly;
        public AutofacMvc(Assembly assembly)
        {
            _assembly = assembly;
        }


        public void Bootstrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(_assembly);
            //builder.RegisterType<CategoryService>().As<ICustomerService>().InstancePerRequest();
            //builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().InstancePerRequest();

            builder.RegisterAssemblyTypes(typeof(CategoryService).Assembly)
              .Where(t => t.Name.EndsWith("Service"))
              .AsImplementedInterfaces().InstancePerRequest();


            builder.RegisterAssemblyTypes(typeof(CategoryRepository).Assembly)
             .Where(t => t.Name.EndsWith("Repository"))
             .AsImplementedInterfaces().InstancePerRequest();


            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
