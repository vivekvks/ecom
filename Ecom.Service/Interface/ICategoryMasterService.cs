using Ecom.Models.Web.Request;
using Ecom.Models.Web.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Service.Interface
{
    public interface ICategoryMasterService
    {
        Task<string> Get();
        Task<GetCategoryMasterResponse> Get(int id);
        Task<GetCategoryMasterResponse> Create(AddCategoryMasterRequest request);
        Task<GetCategoryMasterResponse> Update(int id, AddCategoryMasterRequest request);
        Task Delete(int id);
    }
}
