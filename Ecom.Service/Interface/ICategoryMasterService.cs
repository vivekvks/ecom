using Ecom.Models.Web.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Service.Interface
{
    public interface ICategoryMasterService
    {
        Task<string> Get();
        Task<int> Create(AddCategoryMasterRequest request);
    }
}
