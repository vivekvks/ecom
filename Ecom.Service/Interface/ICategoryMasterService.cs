using Ecom.Models.Request;
using Ecom.Models.Response;

namespace Ecom.Service.Interface
{
    public interface ICategoryMasterService
    {
        public CategoryMasterGetResponse Get(int id);
        string GetHierarchyJson();
        int Add(CategoryMasterAddRequest request);
        int Update(int id, CategoryMasterUpdateRequest request);
        bool Delete(int id);
    }
}
