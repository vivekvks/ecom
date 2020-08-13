using Ecom.Data.Interface;
using Ecom.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Data.Implementation.DBRepo
{
    public class CategoryMasterRepository : GenericRepository<CategoryMaster>, ICategoryMasterRepository
    {
        public CategoryMasterRepository() : base("CategoryMaster")
        {

        }
        public async Task<string> Get()
        {
            var data = await base.GetAllAsync();
            return "test";
        }
    }
}
