using AutoWrapper.Wrappers;
using Ecom.Data.Interface;
using Ecom.Models.Request;
using Ecom.Models.Response;
using Ecom.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Ecom.Service
{
    public class CategoryAttributeMasterService : ICategoryAttributeMasterService
    {
        private readonly ICategoryAttributeMasterRepository _categoryAttributeMasterRepository;
        public CategoryAttributeMasterService(ICategoryAttributeMasterRepository categoryAttributeMasterRepository)
        {
            _categoryAttributeMasterRepository = categoryAttributeMasterRepository;
        }

        public List<int> AddRange(List<CategoryAttributeMasterAddRequest> requests)
        {
            if (requests.Any(x => !x.CategoryId.HasValue))
            {
                throw new ApiException("CategoryId is required.");
            }
            if (requests.Any(x => string.IsNullOrEmpty(x.Name)))
            {
                throw new ApiException("Name is required.");
            }
            return _categoryAttributeMasterRepository.AddRange(requests);
        }

        public List<CategoryAttributeMasterGetResponse> Get(int id)
        {
            return _categoryAttributeMasterRepository.Get(id);
        }

        public bool Delete(int id)
        {
            return _categoryAttributeMasterRepository.Delete(id);
        }
    }
}
