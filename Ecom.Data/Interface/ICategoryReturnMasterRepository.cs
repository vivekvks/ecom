using Ecom.Data.Models;
using Ecom.Models.Response;
using System.Collections.Generic;

namespace Ecom.Data.Interface
{
    public interface ICategoryReturnMasterRepository
    {
        List<CategoryReturnMasterGetResponse> List();
    }
}
