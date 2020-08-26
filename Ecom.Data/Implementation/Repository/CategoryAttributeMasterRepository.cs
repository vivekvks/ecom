using Ecom.Data.Interface;
using Ecom.Data.Models;

namespace Ecom.Data.Implementation.Repository
{
    public class CategoryAttributeMasterRepository : GenericRepository<CategoryAttributeMaster>, ICategoryAttributeMasterRepository
    {
        public CategoryAttributeMasterRepository() : base(nameof(CategoryAttributeMaster))
        {

        }
    }
}
