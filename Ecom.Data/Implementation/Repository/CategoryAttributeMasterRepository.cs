using Ecom.Data.Interface;
using Ecom.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Data.Implementation.Repository
{
    public class CategoryAttributeMasterRepository : GenericRepository<CategoryAttributeMaster>, ICategoryAttributeMasterRepository
    {
        public CategoryAttributeMasterRepository() : base(nameof(CategoryAttributeMaster))
        {

        }
    }
}
