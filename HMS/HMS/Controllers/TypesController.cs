using Autofac;
using HMS.Models;
using HMS.Web.ServicePattern;

using System.Web.Mvc;

namespace HMS.Controllers
{
    public class TypesController : Controller
    {
        private readonly IBedTypeMasterService _IBedTypeMasterService;
        private readonly IRoomTypeMasterService _IRoomTypeMasterService;
        private static IContainer Container { get; set; }

        public  TypesController()
        {
            Container = AutofacConfig.RegisterAutofac();
            using (var scope = Container.BeginLifetimeScope())
            {
                _IBedTypeMasterService = scope.Resolve<IBedTypeMasterService>();
            }
        }
        public TypesController(IBedTypeMasterService IBedTypeMasterService)
        {
            _IBedTypeMasterService = IBedTypeMasterService; 
        }
        //public TypesController()
        //{
        //    Container = AutofacConfig.RegisterAutofac();
        //    using (var scope = Container.BeginLifetimeScope())
        //    {
        //        _IBedTypeMasterService = scope.Resolve<IBedTypeMasterService>();
        //    }
        //}

        public ActionResult SaveBedType(BedTypeModel model)
        {
           if(model != null)
            {
                _IBedTypeMasterService.Save(model);
            }
           
            return View();
        }

        public ActionResult DeleteBedType()
        {
            return View();
        }

        public ActionResult SaveRoomType(RoomTypeModel model)
        { 
             if(model != null)
            {
                _IRoomTypeMasterService.Save(model);
            }
            return View();
        }

        public ActionResult DeleteRoomType()
        {
            return View();
        }


    }
}