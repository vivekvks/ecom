using Ecom.Data.Models;
using Ecom.Models.Request;
using System.Collections.Generic;

namespace Ecom.Data.Interface
{
    public interface ICategoryAttributeMasterRepository
    {
        List<int> AddRange(List<CategoryAttributeMasterAddRequest> requests);
    }
}
