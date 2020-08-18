using Ecom.Data.Interface;
using Ecom.Data.Models;

namespace Ecom.Data.Implementation.Repository
{
    public class CategoryMasterRepository : GenericRepository<CategoryMaster>, ICategoryMasterRepository
    {
        public CategoryMasterRepository() : base("CategoryMaster")
        {

        }
       
    }
}
