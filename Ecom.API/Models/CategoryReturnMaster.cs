using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class CategoryReturnMaster
    {
        public CategoryReturnMaster()
        {
            CategoryMaster = new HashSet<CategoryMaster>();
        }

        public int Id { get; set; }
        public int NoOfDays { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<CategoryMaster> CategoryMaster { get; set; }
    }
}
