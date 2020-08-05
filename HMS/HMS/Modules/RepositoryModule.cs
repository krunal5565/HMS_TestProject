using Autofac;
using System.Reflection;
using Module = Autofac.Module;

namespace HMS.Modules
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("HMS.Repository"))
                           .Where(t => t.Name.EndsWith("Repository"))
                           .AsImplementedInterfaces()
                           .AsSelf()
                           .InstancePerLifetimeScope();
        }
    }
}