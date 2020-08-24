using Ecom.Data.Interface;
using Ecom.Models.Constants;
using Ecom.Models.Web.Request;
using Ecom.Models.Web.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
