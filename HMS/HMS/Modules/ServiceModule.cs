using System.Reflection;
using Autofac;
using Module = Autofac.Module;

namespace HMS.Modules
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("HMS.BusinessPattern"))
               .Where(t => t.Name.EndsWith("Service"))
               .PropertiesAutowired()
               .AsImplementedInterfaces()
                .AsSelf()
               .InstancePerLifetimeScope();
        }
    }
}