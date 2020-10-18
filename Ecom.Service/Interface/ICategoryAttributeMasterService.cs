using Ecom.Models.Request;
using Ecom.Models.Response;
using System.Collections.Generic;

namespace Ecom.Service.Interface
{
    public interface ICategoryAttributeMasterService
    {
        List<int> AddRange(List<CategoryAttributeMasterAddRequest> requests);
        List<CategoryAttributeMasterGetResponse> Get(int id);
    }
}
