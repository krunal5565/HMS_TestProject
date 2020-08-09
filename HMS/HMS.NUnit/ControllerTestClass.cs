using System;
using NUnit.Framework;
using HMS.Controllers; 
using System.Web.Mvc;
using HMS.Models;
using Autofac;
using HMS.Modules;
using HMS.Web.ServicePattern;

namespace HMS.NUnit
{
    [TestFixture]
    public class ControllerTestClass
    {
        private static IContainer Container { get; set; }

        [Test]
        public void TestDepartmentCreateErrorView()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new RepositoryModule());
            builder.RegisterModule(new EFModule());
            builder.RegisterModule(new ServiceModule());
            Container = builder.Build();

            using (var scope = Container.BeginLifetimeScope())
            {
                var objIUserService = scope.Resolve<IUserService>();

                var obj = new UserController(objIUserService);

                ViewResult result = obj.Login(new LoginInputModel()
                {
                    UserID = "1",
                    Password = "123",

                }) as ViewResult;

                Assert.That(result.ViewName, Is.EqualTo("Error"));
            }
        }

        //[Test]
        //public void TestDepartmentCreateView()
        //{
        //    var builder = new ContainerBuilder();

        //    builder.RegisterModule(new RepositoryModule());
        //    builder.RegisterModule(new EFModule());
        //    builder.RegisterModule(new ServiceModule());
        //    Container = builder.Build();

        //    using (var scope = Container.BeginLifetimeScope())
        //    {
        //        var objIUserService = scope.Resolve<IUserService>();

        //        var obj = new UserController(objIUserService);

        //        ViewResult result = obj.SaveUser(new UserModel()
        //        {
        //           FirstName= "krunl",
        //           LastName ="",


        //        }) as ViewResult;

        //        Assert.That(result.ViewName, Is.EqualTo("Error"));
        //    }
        //}
    }
}
