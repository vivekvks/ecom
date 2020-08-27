using Ecom.Models.Request;
using System.Collections.Generic;

namespace Ecom.Service.Interface
{
    public interface ICategoryVarianceDetailsService
    {
        List<int> AddRange(List<CategoryVarianceDetailsAddRequest> requests);
    }
}
