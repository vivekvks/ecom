using Ecom.Data.Models;
using Ecom.Models.Web.Request;
using System.Linq;
namespace Ecom.Data
{
    public class CategoryMasterRepository
    {
        private ECOMContext _context;
        public CategoryMasterRepository()
        {
            _context = new ECOMContext();
        }

        public CategoryMaster AddCategoryMaster(CategoryMaster categoryMaster)
        {

            _context.CategoryMaster.Add(categoryMaster);
            _context.SaveChanges();

            return categoryMaster;

        }

        public CategoryMaster GetCategoryByParentIdName(CategoryMaster categoryMaster)
        {
            return _context.CategoryMaster.Where(
                    x => x.ParentId.Equals(categoryMaster.ParentId) &&
                         x.Name.Equals(categoryMaster.Name)).SingleOrDefault();

        }

        public CategoryMaster UpdateCategoryMaster(CategoryMaster categoryMaster)
        {
            var categoryMasterObj = _context.CategoryMaster.Where(
                x => x.CategoryId.Equals(categoryMaster.CategoryId)).SingleOrDefault();

            if (categoryMasterObj != null)
            {
                categoryMasterObj.Name = categoryMaster.Name;
                _context.SaveChanges();
            }

            return categoryMaster;
        }
    }
}
