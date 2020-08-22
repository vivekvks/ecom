using Ecom.Data.Interface;
using Ecom.Data.Models;
using Ecom.Models.Web.Response;
using Ecom.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Service
{
    public class VarianceMasterService : IVarianceMasterService
    {
        private readonly IVarianceMasterRepository _varianceMasterRepository;
        public VarianceMasterService(IVarianceMasterRepository varianceMasterRepository)
        {
            _varianceMasterRepository = varianceMasterRepository;
        }
        public async Task<List<GetVarianceMasterResponse>> Get()
        {
            var varianceMasters = await _varianceMasterRepository.GetAllAsync();
            return varianceMasters.Where(x => x.IsActive).Select(x => new GetVarianceMasterResponse
            {
                Id = x.Id,
                VarianceName = x.VarianceName,
                IncludeInTitle = x.IncludeInTitle
            }).ToList();
        }
    }
}
