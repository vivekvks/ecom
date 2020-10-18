using Ecom.Models.Request;
using Ecom.Models.Response;
using System.Collections.Generic;

namespace Ecom.Data.Interface
{
    public interface ICategoryAttributeMasterRepository
    {
        List<int> AddRange(List<CategoryAttributeMasterAddRequest> requests);
        List<CategoryAttributeMasterGetResponse> Get(int id);
    }
}
