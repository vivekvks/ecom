using Ecom.Data.Interface;
using Ecom.Models.Request;
using Ecom.Models.Response;
using Ecom.Service.Interface;

namespace Ecom.Service
{
    public class CategoryMasterService : ICategoryMasterService
    {
        private readonly ICategoryMasterRepository _categoryMasterRepository;
        public CategoryMasterService(ICategoryMasterRepository categoryMasterRepository)
        {
            _categoryMasterRepository = categoryMasterRepository;
        }

        public CategoryMasterGetResponse Get(int id)
        {
            return _categoryMasterRepository.Get(id);
        }
        public string GetHierarchyJson(int id, bool isRoot)
        {
            return _categoryMasterRepository.GetHierarchyJson(id, isRoot);
        }

        public int Add(CategoryMasterAddRequest request)
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
