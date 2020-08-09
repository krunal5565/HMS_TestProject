using HMS.BusinessPattern.BusinessLogic.BusinessClasses;
using HMS.BusinessPattern.BusinessLogic.UtilityClasses;
using HMS.Repository.EMDX;
using HMS.Repository.RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq; 

namespace HMS.Web.ServicePattern
{
    public class BedTypeMasterService : IBedTypeMasterService
    {
        private IBedTypeMasterRepository _BedRepository;
        public BedTypeMasterService(IBedTypeMasterRepository Repository)
        {
            _BedRepository = Repository; 
        }

        public bool SaveRedType(BedTypeBAL bedTypeBAL)
        {
            bool success = false;

            try
            {
                if(bedTypeBAL != null)
                {
                    BedTypeMaster _objData = BPAutoMapper.mapper.Map<BedTypeBAL, BedTypeMaster>(bedTypeBAL);

                    _BedRepository.Add(_objData);

                    if (_BedRepository.Save() == 1)
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

        public List<BedTypeBAL> GetAllBedTypeByCompany(string companyUniqueID)
        {
            List<BedTypeBAL> bedTypeBAL = new List<BedTypeBAL>();
            List<BedTypeMaster> _bedTypeMasterList = _BedRepository.GetBy(x => x.CompanyUniqueID == companyUniqueID).ToList();

            if (_bedTypeMasterList != null && _bedTypeMasterList.Count > 0)
            {
                foreach (var objData in _bedTypeMasterList)
                {
                    bedTypeBAL.Add(BPAutoMapper.mapper.Map<BedTypeMaster, BedTypeBAL>(objData));
                }
            }
            return bedTypeBAL;
        }

        public List<BedTypeBAL> GetAllBedTypes()
        {
            List<BedTypeBAL> bedTypeBAL = new List<BedTypeBAL>();
            List<BedTypeMaster> _bedTypeMasterList = _BedRepository.GetAll().ToList();

            if (_bedTypeMasterList != null && _bedTypeMasterList.Count > 0)
            {
                foreach (var objData in _bedTypeMasterList)
                {
                    bedTypeBAL.Add(BPAutoMapper.mapper.Map<BedTypeMaster, BedTypeBAL>(objData));
                }
            }
            return bedTypeBAL;
        }

    }
}
