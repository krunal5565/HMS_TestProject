using Autofac;
using System.Data.Entity;


namespace HMS.Modules
{
    public class EFModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());
        }
    }
}