using Ecom.Data.Interface;
using Ecom.Data.Models;
using System.Threading.Tasks;

namespace Ecom.Data.Implementation.DBRepo
{
    public class CategoryMasterRepository : GenericRepository<CategoryMaster>, ICategoryMasterRepository
    {
        public CategoryMasterRepository() : base("CategoryMaster")
        {

        }
       
    }
}
