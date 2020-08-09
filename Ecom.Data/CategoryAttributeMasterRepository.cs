using Ecom.Data.Models;
using Ecom.Models.Web.Request;
using System.Linq;

namespace Ecom.Data
{
    public class CategoryAttributeMasterRepository
    {
        private ECOMContext _context;
        public CategoryAttributeMasterRepository()
        {
            _context = new ECOMContext();
        }

        public void AddCategoryAttribute(CategoryAttributeIn categoryAttributeIn)
        {
            _context.CategoryAttributeMaster.Add(new CategoryAttributeMaster
            {
                CategoryId = categoryAttributeIn.CategoryId,
                CreatedDate = System.DateTime.Now,
                IsActive = true,
                Name = categoryAttributeIn.Name
            });

            _context.SaveChanges();
        }

        public void UpdateCategoryAttribute(CategoryAttributeIn categoryAttributeIn)
        {
            var updateObj = _context.CategoryAttributeMaster.Where(x => x.CategoryAttributeId.Equals(categoryAttributeIn.Id)).SingleOrDefault();

            updateObj.Name = categoryAttributeIn.Name;
            updateObj.CategoryId = categoryAttributeIn.CategoryId;

            _context.SaveChanges();
        }
    }
}
