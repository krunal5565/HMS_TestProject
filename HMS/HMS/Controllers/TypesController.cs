using HMS.Managers;
using HMS.Models;
using HMS.Web.ServicePattern;

using System.Web.Mvc;

namespace HMS.Controllers
{
    public class TypesController : Controller
    {
        private readonly IBedTypeMasterService _IBedTypeMasterService;
        private readonly IRoomTypeMasterService _IRoomTypeMasterService;
        public TypeManager typeManager = null;

        public  TypesController()
        {
           
        }
        public TypesController(IBedTypeMasterService IBedTypeMasterService, IRoomTypeMasterService IRoomTypeMasterService)
        {
            _IBedTypeMasterService = IBedTypeMasterService;
            _IRoomTypeMasterService = IRoomTypeMasterService; 
        }
      

        public ActionResult SaveBedType(BedTypeModel model)
        {
           if(model != null)
            {
                typeManager = new TypeManager(_IBedTypeMasterService, _IRoomTypeMasterService); 
                typeManager.SaveBedType(model);
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
                typeManager = new TypeManager(_IBedTypeMasterService, _IRoomTypeMasterService);
                typeManager.SaveRoomType(model);
            }
            return View();
        }

        public ActionResult DeleteRoomType()
        {
            return View();
        }


    }
}