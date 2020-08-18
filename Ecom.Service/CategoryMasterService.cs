using Ecom.Data.Interface;
using Ecom.Data.Models;
using Ecom.Models.Web.Request;
using Ecom.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Service
{
    public class CategoryMasterService : ICategoryMasterService
    {
        private readonly ICategoryMasterRepository _categoryMasterRepository;
        public CategoryMasterService(ICategoryMasterRepository categoryMasterRepository)
        {
            _categoryMasterRepository = categoryMasterRepository;
        }
        public Task<string> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<int> Create(AddCategoryMasterRequest request)
        {
            if (request.ParentId.HasValue)
            {
                var parentCategory = await _categoryMasterRepository.GetAsync(request.ParentId.Value);
                if (parentCategory == null)
                {
                    throw new Exception($"{request.ParentId.Value} parent category master is not found.");
                }

            }
            var categoryMaster = new CategoryMaster
            {
                Name = request.Name,
                ParentId = request.ParentId
            };
           return await _categoryMasterRepository.InsertAsync(categoryMaster);
            //return 22;
        }
    }
}
