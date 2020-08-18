using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class ListingVarianceDetails
    {
        public int Id { get; set; }
        public int ProductListingId { get; set; }
        public int VarianceMasterId { get; set; }
        public int VarianceValueId { get; set; }
        public bool IsActive { get; set; }

        public virtual ProductListing ProductListing { get; set; }
        public virtual VarianceMaster VarianceMaster { get; set; }
        public virtual VarianceValue VarianceValue { get; set; }
    }
}
