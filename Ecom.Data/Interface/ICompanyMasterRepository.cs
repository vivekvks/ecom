using Ecom.Models.Request;
using Ecom.Models.Response;

namespace Ecom.Data.Interface
{
    public interface ICompanyMasterRepository
    {
        CompanyRegistrationResponse CompanyRegistration(CompanyRegistrationRequest request);
    }
}
