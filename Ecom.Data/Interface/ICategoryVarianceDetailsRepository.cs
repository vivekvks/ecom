using Ecom.Models.Request;
using Ecom.Models.Response;
using System.Collections.Generic;

namespace Ecom.Data.Interface
{
    public interface ICategoryVarianceDetailsRepository
    {
        List<int> AddRange(List<CategoryVarianceDetailsAddRequest> requests);
        List<CategoryVarianceDetailsGetResponse> Get(int id);
        bool Delete(int id);
    }
}
