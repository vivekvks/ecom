using Ecom.Models.Response.VarianceMaster;
using System.Collections.Generic;

namespace Ecom.Service.Interface
{
    public interface IVarianceMasterService
    {
        List<VarianceMasterGetResponse> List();
    }
}
