using Ecom.Data.Interface;
using Ecom.Data.Models;

namespace Ecom.Data.Implementation.Repository
{
    public class CategoryVarianceDetailsRepository : GenericRepository<CategoryVarianceDetails>, ICategoryVarianceDetailsRepository
    {
        public CategoryVarianceDetailsRepository() : base(nameof(CategoryVarianceDetails))
        {

        }
    }
}
