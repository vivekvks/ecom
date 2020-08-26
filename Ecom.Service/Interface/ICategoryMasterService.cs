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
        public CategoryMasterGetResponse Get(int id);
        int Create(CategoryMasterAddRequest request);
        int Update(int id, CategoryMasterUpdateRequest request);
        bool Delete(int id);
    }
}
