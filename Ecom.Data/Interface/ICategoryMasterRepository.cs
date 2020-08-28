using Ecom.Models.Request;
using Ecom.Models.Response;

namespace Ecom.Data.Interface
{
    public interface ICategoryMasterRepository
    {
        CategoryMasterGetResponse Get(int id);
        string GetHierarchyJson();
        int Add(CategoryMasterAddRequest request);
        int Update(int id, CategoryMasterUpdateRequest request);
        bool Delete(int id);
    }
}
