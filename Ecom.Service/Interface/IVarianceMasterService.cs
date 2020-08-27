using Ecom.Models.Response;
using Ecom.Models.Response.VarianceMaster;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecom.Service.Interface
{
    public interface IVarianceMasterService
    {
        List<VarianceMasterGetResponse> List();
    }
}
