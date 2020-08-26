using Ecom.Data.Interface;
using Ecom.Models.Request;
using Ecom.Models.Response;
using Ecom.Service.Interface;

namespace Ecom.Service
{
    public class CategoryMasterService : ICategoryMasterService
    {
        private readonly ICategoryMasterRepository _categoryMasterRepository;
        private readonly ICategoryReturnMasterRepository _categoryReturnMasterRepository;
        public CategoryMasterService(ICategoryMasterRepository categoryMasterRepository,
            ICategoryReturnMasterRepository categoryReturnMasterRepository)
        {
            _categoryMasterRepository = categoryMasterRepository;
            _categoryReturnMasterRepository = categoryReturnMasterRepository;
        }

        public CategoryMasterGetResponse Get(int id)
        {
            return _categoryMasterRepository.Get(id);
        }

        public int Create(CategoryMasterAddRequest request)
        {
            return _categoryMasterRepository.Add(request);
        }

        public int Update(int id, CategoryMasterUpdateRequest request)
        {
            return _categoryMasterRepository.Update(id, request);
        }

        public bool Delete(int id)
        {
            return _categoryMasterRepository.Delete(id);
        }
    }
}
