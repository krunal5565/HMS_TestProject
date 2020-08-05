using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using HMS.Web.ServicePattern;

namespace HMS
{
    public class AutofacConfig
    {
        public static IContainer RegisterAutofac()
        {
            var builder = new ContainerBuilder();
          builder.RegisterType<BedTypeMasterService>().As<IBedTypeMasterService>().SingleInstance().PreserveExistingDefaults(); ;
       

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            return container;
        }
    }
}