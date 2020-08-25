using Ecom.Data.Interface;
using Ecom.Models.Web.Request;
using Ecom.Models.Web.Response;
using Ecom.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

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
