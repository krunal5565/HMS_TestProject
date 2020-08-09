using HMS.BusinessPattern.BusinessLogic.BusinessClasses;
using HMS.BusinessPattern.BusinessLogic.UtilityClasses;
using HMS.Models;
using HMS.Repository.EMDX;
using HMS.Web.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS.Managers
{
    public class TypeManager
    {
        private readonly IBedTypeMasterService _BedTypeMasterService;
        private readonly IRoomTypeMasterService _RoomTypeMasterService;
        public TypeManager(IBedTypeMasterService IBedTypeMasterService, IRoomTypeMasterService RoomTypeMasterService)
        {
            _BedTypeMasterService = IBedTypeMasterService;
            _RoomTypeMasterService = RoomTypeMasterService; 
        }

        public bool SaveBedType(BedTypeModel model)
        {
            bool success = false;

            if(model != null)
            {
                BedTypeBAL bedTypeBAL = HMSAutoMapper.mapper.Map<BedTypeModel, BedTypeBAL>(model);
                _BedTypeMasterService.SaveRedType(bedTypeBAL);
            }
            
            return success;
        }
        public bool SaveRoomType(RoomTypeModel model)
        {
            bool success = false;

            if(model != null)
            {
                RoomTypeBAL roomTypeBAL = HMSAutoMapper.mapper.Map<RoomTypeModel, RoomTypeBAL>(model);
                _RoomTypeMasterService.SaveRoomType(roomTypeBAL);
            }
          
            return success;
        }
        public List<RoomTypeModel> GetAllRooms()
        {
            List<RoomTypeModel> roomTypeModelList = new List<RoomTypeModel>();
            List<RoomTypeBAL> _roomTypeMasterList = _RoomTypeMasterService.GetAllRoomTypes();

            if (_roomTypeMasterList != null && _roomTypeMasterList.Count > 0)
            {
                foreach (var obj in _roomTypeMasterList)
                {
                    roomTypeModelList.Add(HMSAutoMapper.mapper.Map<RoomTypeBAL, RoomTypeModel>(obj));
                }
            }

            return roomTypeModelList;
        }
        public List<RoomTypeModel> GetAllRoomsByCompany(string companyName)
        {
            List<RoomTypeModel> roomTypeModelList = new List<RoomTypeModel>();
            List<RoomTypeBAL> _roomTypeMasterList = _RoomTypeMasterService.GetAllRoomTypeByCompany(companyName);

            if (_roomTypeMasterList != null && _roomTypeMasterList.Count > 0)
            {
                foreach (var obj in _roomTypeMasterList)
                {
                    roomTypeModelList.Add(HMSAutoMapper.mapper.Map<RoomTypeBAL, RoomTypeModel>(obj));
                }
            }

            return roomTypeModelList;
        }

        public List<BedTypeModel> GetAllBedTypes()
        {
            List<BedTypeModel> bedTypeModelList = new List<BedTypeModel>();
            List<BedTypeBAL> _bedTypeMasterList = _BedTypeMasterService.GetAllBedTypes();

            if (_bedTypeMasterList != null && _bedTypeMasterList.Count > 0)
            {
                foreach (var obj in _bedTypeMasterList)
                {
                    bedTypeModelList.Add(HMSAutoMapper.mapper.Map<BedTypeBAL, BedTypeModel>(obj));
                }
            }

            return bedTypeModelList;
        }
        public List<BedTypeModel> GetAllBedTypesByCompany(string companyName)
        {
            List<BedTypeModel> bedTypeModelList = new List<BedTypeModel>();
            List<BedTypeBAL> _bedTypeMasterList = _BedTypeMasterService.GetAllBedTypeByCompany(companyName);

            if (_bedTypeMasterList != null && _bedTypeMasterList.Count > 0)
            {
                foreach (var obj in _bedTypeMasterList)
                {
                    bedTypeModelList.Add(HMSAutoMapper.mapper.Map<BedTypeBAL, BedTypeModel>(obj));
                }
            }

            return bedTypeModelList;
        }
    }
}