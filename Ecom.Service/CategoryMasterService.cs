using Ecom.Data.Interface;
using Ecom.Data.Models;
using Ecom.Models.Web.Request;
using Ecom.Models.Web.Response;
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
        public async Task<GetCategoryMasterResponse> Get(int id)
        {
            var categoryMaster = await _categoryMasterRepository.GetAsync(id);
            if(categoryMaster == null)
            {
                throw new Exception($"{id} category master is not found.");
            }
            return new GetCategoryMasterResponse
            {
                Id = categoryMaster.Id,
                Name = categoryMaster.Name,
                ParentId = categoryMaster.ParentId,
                ReturnTypeId = categoryMaster.ReturnTypeId
            };
        }

        public async Task<GetCategoryMasterResponse> Create(AddCategoryMasterRequest request)
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
            var categoryMasterId = await _categoryMasterRepository.InsertAsync(categoryMaster);
            return await Get(categoryMasterId);
        }
    }
}
