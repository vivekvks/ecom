using Ecom.Models.Request;
using Ecom.Models.Response;
using System.Collections.Generic;

namespace Ecom.Service.Interface
{
    public interface ICategoryVarianceDetailsService
    {
        List<int> AddRange(List<CategoryVarianceDetailsAddRequest> requests);
        List<CategoryVarianceDetailsGetResponse> Get(int id);
        bool Delete(int id);
    }
}
