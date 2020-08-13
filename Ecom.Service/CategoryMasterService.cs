using Ecom.Data.Interface;
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
        public async Task<string> Get()
        {
            return await _categoryMasterRepository.Get();
        }
    }
}
