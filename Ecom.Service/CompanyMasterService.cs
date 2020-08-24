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
