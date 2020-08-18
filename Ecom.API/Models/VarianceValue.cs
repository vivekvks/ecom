using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class VarianceValue
    {
        public VarianceValue()
        {
            ListingVarianceDetails = new HashSet<ListingVarianceDetails>();
        }

        public int Id { get; set; }
        public int VarianceId { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<ListingVarianceDetails> ListingVarianceDetails { get; set; }
    }
}
