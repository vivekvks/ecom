using Ecom.Models.Request;
using System.Collections.Generic;

namespace Ecom.Service.Interface
{
    public interface ICategoryAttributeMasterService
    {
        List<int> AddRange(List<CategoryAttributeMasterAddRequest> requests);
    }
}
