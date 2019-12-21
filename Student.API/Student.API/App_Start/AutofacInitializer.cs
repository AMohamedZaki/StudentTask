using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Student.API.Modules;
using Student.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Student.API.App_Start
{
    public class AutofacInitializer
    {
        public static void Initialize(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            // to be Able to pass as parameter in constractor
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()); //Register WebApi Controllers
            builder.RegisterApiControllers(Assembly.GetCallingAssembly());
            builder.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);
            builder.RegisterModule(new RepositoryModule());
            builder.RegisterModule(new ServiceModule());
            builder.RegisterModule(new EFModule());
            builder.RegisterType<StudentContext>().AsSelf();
            var container = builder.Build();
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}