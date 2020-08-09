using System;
using System.Collections.Generic;

namespace Ecom.Data.Models
{
    public partial class VarianceValue
    {
        public VarianceValue()
        {
            ListingVarianceDetails = new HashSet<ListingVarianceDetails>();
        }

        public int VarianceValueId { get; set; }
        public int VarianceId { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<ListingVarianceDetails> ListingVarianceDetails { get; set; }
    }
}
