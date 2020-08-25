using Ecom.Models.Web.Request;
using Ecom.Models.Web.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Data.Interface
{
    public interface ICompanyMasterRepository
    {
        CompanyRegistrationResponse CompanyRegistration(CompanyRegistrationRequest request);
        CompanyGetResponse CompanyGet(int companyId);
    }
}
