using HMS.BusinessPattern.BusinessLogic.BusinessClasses;
using System.Collections.Generic;

namespace HMS.Web.ServicePattern
{
    public interface IRoomTypeMasterService
    {
        bool SaveRoomType(RoomTypeBAL roomTypeBAL);
        List<RoomTypeBAL> GetAllRoomTypeByCompany(string companyUniqueID);
        List<RoomTypeBAL> GetAllRoomTypes(); 
    }
}
