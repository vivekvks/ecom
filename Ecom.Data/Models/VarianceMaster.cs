using System;
using System.Collections.Generic;

namespace Ecom.Data.Models
{
    public partial class VarianceMaster
    {
        public VarianceMaster()
        {
            CategoryVarianceDetails = new HashSet<CategoryVarianceDetails>();
            ListingVarianceDetails = new HashSet<ListingVarianceDetails>();
        }

        public int VarianceId { get; set; }
        public string VarianceName { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<CategoryVarianceDetails> CategoryVarianceDetails { get; set; }
        public virtual ICollection<ListingVarianceDetails> ListingVarianceDetails { get; set; }
    }
}
