using Autofac;
using System.Reflection;
using System.Linq;

namespace Student.API.Modules
{
    public class ServiceModule : Autofac.Module
    {
        // Load Services Assembly
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterAssemblyTypes(Assembly.Load("Student.Service"))
                .Where(asseble => asseble.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}