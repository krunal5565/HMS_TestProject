using HMS.BusinessPattern.BusinessLogic.BusinessClasses;
using HMS.BusinessPattern.BusinessLogic.UtilityClasses;
using HMS.Repository.EMDX;
using HMS.Repository.RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace HMS.Web.ServicePattern
{
    public class RoomTypeMasterService : IRoomTypeMasterService
    {
        private IRoomTypeMasterRepository _roomRepository;
        public RoomTypeMasterService(IRoomTypeMasterRepository Repository)
        {
            _roomRepository = Repository;
        }


        public bool SaveRoomType(RoomTypeBAL roomTypeBAL)
        {
            bool success = false;

            try
            {
                if (roomTypeBAL != null)
                {
                    RoomTypeMaster _objData = BPAutoMapper.mapper.Map<RoomTypeBAL, RoomTypeMaster>(roomTypeBAL);
                    _roomRepository.Add(_objData);

                    if (_roomRepository.Save() == 1)
                    {
                        success = true;
                    }
                }
               
            }
            catch (Exception ex)
            {
                success = false;
            }

            return success;
        }
        public List<RoomTypeBAL> GetAllRoomTypeByCompany(string companyUniqueID)
        {
            List<RoomTypeBAL> roomTypeBAL = new List<RoomTypeBAL>();
            List<RoomTypeMaster> _roomTypeMasterList = _roomRepository.GetBy(x => x.CompanyUniqueID == companyUniqueID).ToList();

            if (_roomTypeMasterList != null && _roomTypeMasterList.Count > 0)
            {
                foreach (var objData in _roomTypeMasterList)
                {
                    roomTypeBAL.Add(BPAutoMapper.mapper.Map<RoomTypeMaster, RoomTypeBAL>(objData));
                }
            }
            return roomTypeBAL;
        }
        public List<RoomTypeBAL> GetAllRoomTypes()
        {
            List<RoomTypeBAL> roomTypeBAL = new List<RoomTypeBAL>();
            List<RoomTypeMaster> _roomTypeMasterList = _roomRepository.GetAll().ToList();

            if (_roomTypeMasterList != null && _roomTypeMasterList.Count > 0)
            {
                foreach (var objData in _roomTypeMasterList)
                {
                    roomTypeBAL.Add(BPAutoMapper.mapper.Map<RoomTypeMaster, RoomTypeBAL>(objData));
                }
            }
            return roomTypeBAL;
        }

    }
}

