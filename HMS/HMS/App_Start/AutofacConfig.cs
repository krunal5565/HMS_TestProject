using Autofac;
using Autofac.Integration.Mvc;
using HMS.Modules;
using HMS.Repository;
using HMS.Web.ServicePattern;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMS.App_Start
{
    public class AutofacConfig
    {
        public static IContainer RegisterAutofac()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new RepositoryModule());
            builder.RegisterType(typeof(HMSEntities)).As(typeof(DbContext)).InstancePerLifetimeScope();
            builder.RegisterModule(new ServiceModule());
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            return container;
        }
    }
}