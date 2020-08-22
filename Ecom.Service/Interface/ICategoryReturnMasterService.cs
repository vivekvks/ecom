using Ecom.Models.Web.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Service.Interface
{
    public interface ICategoryReturnMasterService
    {
        Task<List<GetCategoryReturnMasterResponse>> Get();
    }
}
