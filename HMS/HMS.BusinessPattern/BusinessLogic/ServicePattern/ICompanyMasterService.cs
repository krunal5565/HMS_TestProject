using HMS.BusinessPattern.BusinessLogic.BusinessClasses;
using System.Collections.Generic;

namespace HMS.Web.ServicePattern
{
    public interface ICompanyMasterService
    {
        bool CreateCompany(CompanyBAL model);
        List<CompanyBAL> GetAllCompany(); 

    }
}
