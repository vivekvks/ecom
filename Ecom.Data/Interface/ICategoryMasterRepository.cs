using Ecom.Data.Models;
using Ecom.Models.Web.Request;
using Ecom.Models.Web.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Data.Interface
{
    public interface ICategoryMasterRepository
    {
        CategoryMasterGetResponse Get(int id);
        int Add(CategoryMasterAddRequest request);
        int Update(int id, CategoryMasterUpdateRequest request);
        bool Delete(int id);
    }
}
