using Ecom.Data.Interface;
using Ecom.Models.Request;
using Ecom.Models.Response;
using Ecom.Service.Interface;

namespace Ecom.Service
{
    public class CompanyMasterService : ICompanyMasterService
    {
        private readonly ICompanyMasterRepository _CompanyMasterRepository;
        public CompanyMasterService(ICompanyMasterRepository CompanyMasterRepository)
        {
            _CompanyMasterRepository = CompanyMasterRepository;
        }

        public CompanyRegistrationResponse CompanyRegistration(CompanyRegistrationRequest request)
        {
            return _CompanyMasterRepository.CompanyRegistration(request);
        }
    }
}
