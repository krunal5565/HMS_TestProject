using HMS.Models;
using HMS.Repository.EDMX;
using HMS.Repository.EMDX;
using HMS.Repository.RepositoryPattern;
using System;

namespace HMS.Web.ServicePattern
{
    public class RoomTypeMasterService : IRoomTypeMasterService
    {

        private IRoomTypeMasterRepository _Repository;

        public RoomTypeMasterService(IRoomTypeMasterRepository Repository)
        {
            _Repository = Repository;
        }

        public void Save(RoomTypeModel model)
        {
            RoomTypeMaster _objData = new RoomTypeMaster();
            _objData.RoomTypeName = model.RoomTypeName;
            _objData.RoomTypeCode = model.RoomTypeCode;
            _objData.ActiveStatus = model.ActiveStatus;
            _objData.UniqueID = Guid.NewGuid().ToString(); 

            _Repository.Add(_objData);
            _Repository.Save();
        }

    }
}
