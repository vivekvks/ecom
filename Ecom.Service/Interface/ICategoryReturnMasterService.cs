using Ecom.Models.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecom.Service.Interface
{
    public interface ICategoryReturnMasterService
    {
        Task<List<GetCategoryReturnMasterResponse>> Get();
    }
}
