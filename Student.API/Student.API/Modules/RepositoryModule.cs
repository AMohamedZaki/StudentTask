using Autofac;
using System.Linq;
using System.Reflection;

namespace Student.API.Modules
{
    public class RepositoryModule : Autofac.Module
    {
        // Load Repository Assembly
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterAssemblyTypes(Assembly.Load("Student.Repo"))
                .Where(asseble => asseble.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}