using Ecom.Data.Interface;
using Ecom.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Service
{
    public class CategoryMasterService : ICategoryMasterService
    {
        public CategoryMasterService(ICategoryMasterRepository categoryMasterRepository)
        {

        }

        public Task<string> Get()
        {
            throw new NotImplementedException();
        }
    }
}
