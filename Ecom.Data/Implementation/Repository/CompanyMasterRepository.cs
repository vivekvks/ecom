using Ecom.Data.Interface;
using Ecom.Models.Constants;
using Ecom.Models.Request;
using Ecom.Models.Response;
using System.Linq;

namespace Ecom.Data.Implementation.Repository
{
    public class CompanyMasterRepository : ICompanyMasterRepository
    {
        private readonly IRepository _repository;
        public CompanyMasterRepository(IRepository repository)
        {
            _repository = repository;
        }

        public CompanyRegistrationResponse CompanyRegistration(CompanyRegistrationRequest request)
        {
            return _repository.ExecResult<CompanyRegistrationResponse>(StoredProcedure.COMPANY_REGISTRATION, _repository.GetBaseParameters(request)).FirstOrDefault();
        }
    }
}
