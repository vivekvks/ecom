using Ecom.Models.Request;
using System.Collections.Generic;

namespace Ecom.Service.Interface
{
    public interface ICategoryVarianceDetailsService
    {
        bool Create(List<CategoryVarianceDetailsAddRequest> addRequests);
    }
}
