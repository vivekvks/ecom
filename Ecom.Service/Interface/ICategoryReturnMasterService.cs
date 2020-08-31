using Ecom.Models.Response;
using System.Collections.Generic;

namespace Ecom.Service.Interface
{
    public interface ICategoryReturnMasterService
    {
        List<CategoryReturnMasterGetResponse> List();
    }
}
