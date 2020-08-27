using Ecom.Models.Request;
using System.Collections.Generic;

namespace Ecom.Data.Interface
{
    public interface ICategoryVarianceDetailsRepository
    {
        List<int> AddRange(List<CategoryVarianceDetailsAddRequest> requests);
    }
}
