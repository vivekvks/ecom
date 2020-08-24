using Ecom.Models.Web.Request;
using System.Collections.Generic;

namespace Ecom.Service.Interface
{
    public interface ICategoryAttributeMasterService
    {
        bool Create(List<CategoryAttributeMasterAddRequest> addRequests);
    }
}
