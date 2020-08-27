using Ecom.Data.Models;
using Ecom.Models.Response.VarianceMaster;
using System.Collections.Generic;

namespace Ecom.Data.Interface
{
    public interface IVarianceMasterRepository
    {
        List<VarianceMasterGetResponse> List();
    }
}
