using Ecom.Models.Request;
using Ecom.Models.Response;

namespace Ecom.Service.Interface
{
    public interface ICompanyMasterService
    {
        CompanyRegistrationResponse CompanyRegistration(CompanyRegistrationRequest request);
    }
}
