using Ecom.Models.Request;
using Ecom.Models.Response;

namespace Ecom.Service.Interface
{
    public interface ICategoryMasterService
    {
        public CategoryMasterGetResponse Get(int id);
        int Create(CategoryMasterAddRequest request);
        int Update(int id, CategoryMasterUpdateRequest request);
        bool Delete(int id);
    }
}
