using Ecom.Data.Interface;
using Ecom.Models.Response.VarianceMaster;
using Ecom.Service.Interface;
using System.Collections.Generic;

namespace Ecom.Service
{
    public class VarianceMasterService : IVarianceMasterService
    {
        private readonly IVarianceMasterRepository _varianceMasterRepository;
        public VarianceMasterService(IVarianceMasterRepository varianceMasterRepository)
        {
            _varianceMasterRepository = varianceMasterRepository;
        }
        public List<VarianceMasterGetResponse> List()
        {
            return _varianceMasterRepository.List();
        }
    }
}
