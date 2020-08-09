using HMS.BusinessPattern.BusinessLogic.BusinessClasses;
using System.Collections.Generic;

namespace HMS.Web.ServicePattern
{
    public interface IBedTypeMasterService
    {
        bool SaveRedType(BedTypeBAL bedTypeBAL);
        List<BedTypeBAL> GetAllBedTypeByCompany(string companyUniqueID);
        List<BedTypeBAL> GetAllBedTypes(); 

    }
}
