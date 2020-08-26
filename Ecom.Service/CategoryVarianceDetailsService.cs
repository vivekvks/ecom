using AutoWrapper.Wrappers;
using Ecom.Data.Interface;
using Ecom.Models.Request;
using Ecom.Service.Interface;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Ecom.Service
{
    public class CategoryVarianceDetailsService : ICategoryVarianceDetailsService
    {
        private readonly ICategoryVarianceDetailsRepository _categoryVarianceDetailsRepository;
        public CategoryVarianceDetailsService(ICategoryVarianceDetailsRepository categoryVarianceDetailsRepository)
        {
            _categoryVarianceDetailsRepository = categoryVarianceDetailsRepository;
        }

        public bool Create(List<CategoryVarianceDetailsAddRequest> addRequests)
        {
            if (addRequests.Any(x => !x.VarianceMasterId.HasValue && string.IsNullOrEmpty(x.VarianceMasterName)))
            {
                throw new ApiException("Variance details can not be null.");
            }

            string jsonString = JsonConvert.SerializeObject(addRequests);
            var param = new
            {
                JsonString = jsonString
            };
            _categoryVarianceDetailsRepository.Exec("InsertCategoryVarianceDetails", param);

            return true;
        }
    }
}
