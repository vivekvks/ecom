using Ecom.Data.Interface;
using Ecom.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Data.Implementation.Repository
{
    public class CategoryVarianceDetailsRepository : GenericRepository<CategoryVarianceDetails>, ICategoryVarianceDetailsRepository
    {
        public CategoryVarianceDetailsRepository() : base(nameof(CategoryVarianceDetails))
        {

        }
    }
}
