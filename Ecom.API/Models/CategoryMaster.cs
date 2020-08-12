using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class CategoryMaster
    {
        public CategoryMaster()
        {
            CategoryAttributeMaster = new HashSet<CategoryAttributeMaster>();
            CategoryVarianceDetails = new HashSet<CategoryVarianceDetails>();
            InverseParent = new HashSet<CategoryMaster>();
        }

        public int CategoryId { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }

        public virtual CategoryMaster Parent { get; set; }
        public virtual ICollection<CategoryAttributeMaster> CategoryAttributeMaster { get; set; }
        public virtual ICollection<CategoryVarianceDetails> CategoryVarianceDetails { get; set; }
        public virtual ICollection<CategoryMaster> InverseParent { get; set; }
    }
}
