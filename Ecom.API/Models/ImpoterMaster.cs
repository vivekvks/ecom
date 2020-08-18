using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class ImpoterMaster
    {
        public ImpoterMaster()
        {
            ProductListing = new HashSet<ProductListing>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<ProductListing> ProductListing { get; set; }
    }
}
