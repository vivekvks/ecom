using System;
using System.Collections.Generic;

namespace Ecom.Data.Models
{
    public partial class ImpoterMaster
    {
        public ImpoterMaster()
        {
            ProductListing = new HashSet<ProductListing>();
        }

        public int ImpoterId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<ProductListing> ProductListing { get; set; }
    }
}
