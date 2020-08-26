using Ecom.Data.Interface;
using Ecom.Models.Response;
using Ecom.Service.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Service
{
    public class CategoryReturnMasterService : ICategoryReturnMasterService
    {
        private readonly ICategoryReturnMasterRepository _categoryReturnMasterRepository;
        public CategoryReturnMasterService(ICategoryReturnMasterRepository categoryReturnMasterRepository)
        {
            _categoryReturnMasterRepository = categoryReturnMasterRepository;
        }
        public async Task<List<GetCategoryReturnMasterResponse>> Get()
        {
            var categoryReturnMasters = await _categoryReturnMasterRepository.GetAllAsync(true);
            return categoryReturnMasters.Select(x => new GetCategoryReturnMasterResponse
            {
                Id = x.Id,
                NoOfDays = x.NoOfDays,
                Description = x.Description
            }).ToList();
        }
    }
}
