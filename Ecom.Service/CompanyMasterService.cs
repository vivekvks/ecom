using Ecom.Data.Interface;
using Ecom.Models.Request;
using Ecom.Models.Response;
using Ecom.Service.Interface;

namespace Ecom.Service
{
    public class CompanyMasterService : ICompanyMasterService
    {
        private readonly ICompanyMasterRepository _companyMasterRepository;
        public CompanyMasterService(ICompanyMasterRepository companyMasterRepository)
        {
            _companyMasterRepository = companyMasterRepository;
        }

        public CompanyRegistrationResponse CompanyRegistration(CompanyRegistrationRequest request)
        {
            return _companyMasterRepository.CompanyRegistration(request);
        }

        public CompanyGetResponse CompanyGet(int companyId)
        {
            return _companyMasterRepository.CompanyGet(companyId);
        }
    }
}
