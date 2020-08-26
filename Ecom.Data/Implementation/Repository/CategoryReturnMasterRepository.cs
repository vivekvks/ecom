using Ecom.Data.Interface;
using Ecom.Data.Models;

namespace Ecom.Data.Implementation.Repository
{
    public class CategoryReturnMasterRepository : GenericRepository<CategoryReturnMaster>, ICategoryReturnMasterRepository
    {
        public CategoryReturnMasterRepository() : base(nameof(CategoryReturnMaster))
        {

        }
    }
}
