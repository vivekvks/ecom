using AutoWrapper.Wrappers;
using Ecom.Data.Interface;
using Ecom.Models.Request;
using Ecom.Service.Interface;
using Newtonsoft.Json;
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

        public bool Create(List<CategoryAttributeMasterAddRequest> addRequests)
        {
            if (addRequests.Any(x => !x.CategoryId.HasValue))
            {
                throw new ApiException("CategoryId is required.");
            }
            if (addRequests.Any(x => string.IsNullOrEmpty(x.Name)))
            {
                throw new ApiException("Name is required.");
            }

            string jsonString = JsonConvert.SerializeObject(addRequests);
            var param = new
            {
                JsonString = jsonString
            };
            _categoryAttributeMasterRepository.Exec("CategoryAttributeMaster_Insert", param);
            return true;
        }
    }
}
