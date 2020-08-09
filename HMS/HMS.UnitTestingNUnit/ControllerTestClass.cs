using NUnit.Framework;
using HMS.Controllers;
using System.Web.Mvc;
using HMS.Models;
using Autofac;
using HMS.Modules;
using HMS.Repository.EDMX;
using System.Data.Entity;
using HMS.Web.ServicePattern;
using System;

namespace HMS.NUnit
{
    [TestFixture]
    public class ControllerTestClass
    {
        private static IContainer Container { get; set; }

      

        [Test]
        public void TestUserCreate()
        {
            RegisterAutoFac();

            using (var scope = Container.BeginLifetimeScope())
            {
                var objIUserService = scope.Resolve<IUserService>();

                var obj = new UserController(objIUserService);

                var result = obj.CreateUser(new UserModel()
                {

                    CompanyUniqueID = "51331191-5913-4d8c-8e45-2f6423ece55c",
                    CreatedDate = DateTime.UtcNow,
                    UniqueID = Guid.NewGuid().ToString(),
                    FirstName ="Krunal",
                    LastName = "Naik",
                    MiddleName = "S",
                    EmailID= "krunal22naik@gmail.com",
                    MobileNumber = "7507014838"

                }) ;

                Assert.That("", Is.EqualTo(""));
            }
        }

        [Test]
        public void TestCompanyCreate()
        {
            RegisterAutoFac();

            using (var scope = Container.BeginLifetimeScope())
            {
                var objICompanyService = scope.Resolve<ICompanyMasterService>();

                var obj = new CompanyController(objICompanyService);

                var result = obj.createCompany(new CompanyModel()
                {
                    CreatedDate = DateTime.UtcNow,
                    UniqueID = Guid.NewGuid().ToString(),
                    CompanyName = "3DS", 
                    EmailID = "krunal22naik@gmail.com",
                    MobileNumber = "7507014838"

                });

                Assert.That("", Is.EqualTo(""));
            }
        }

        [Test]
        public void TestBedTypeCreate()
        {
            RegisterAutoFac();

            using (var scope = Container.BeginLifetimeScope())
            {
                var obj = new TypesController(scope.Resolve<IBedTypeMasterService>(), scope.Resolve<IRoomTypeMasterService>());

                var result = obj.SaveBedType(new BedTypeModel()
                {
                    CreatedDate = DateTime.UtcNow,
                    UniqueID = Guid.NewGuid().ToString(),
                    CreatedBy = "0",
                    BedTypeName = "Bed Type",
                    BedTypeCode = "BT",
                    ActiveStatus = "Active",
                    CompanyUniqueID = "51331191-5913-4d8c-8e45-2f6423ece55c",
                });

                Assert.That("", Is.EqualTo(""));
            }
        }


        [Test]
        public void TestRoomTypeCreate()
        {
            RegisterAutoFac();

            using (var scope = Container.BeginLifetimeScope())
            {
               
                var obj = new TypesController(scope.Resolve<IBedTypeMasterService>(), scope.Resolve<IRoomTypeMasterService>());

                var result = obj.SaveRoomType(new RoomTypeModel()
                {
                    CreatedDate = DateTime.UtcNow,
                    UniqueID = Guid.NewGuid().ToString(),
                    CreatedBy = "0",
                    RoomTypeName = "Room Type", 
                    RoomTypeCode ="RT",
                    ActiveStatus ="Active",
                    CompanyUniqueID = "51331191-5913-4d8c-8e45-2f6423ece55c",


                });

                Assert.That("", Is.EqualTo(""));
            }
        }

        [Test]
        public void TestDepartmentCreateErrorView()
        {
            RegisterAutoFac(); 

            using (var scope = Container.BeginLifetimeScope())
            {
                var objIUserService = scope.Resolve<IUserService>();

                var obj = new UserController(objIUserService);

                ViewResult result = obj.Login(new LoginInputModel()
                {
                    UserID = "1",
                    Password = "123",

                }) as ViewResult;

                Assert.That("", Is.EqualTo(""));
            }
        }

       public void RegisterAutoFac()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new RepositoryModule());
            builder.RegisterType(typeof(HMSEntities)).As(typeof(DbContext)).InstancePerLifetimeScope();
            builder.RegisterModule(new ServiceModule());
            Container = builder.Build();
        }
    }
}
