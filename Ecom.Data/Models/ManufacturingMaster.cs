using System.Collections.Generic;

namespace Ecom.Data.Models
{
    public partial class ManufacturingMaster
    {
        public ManufacturingMaster()
        {
            ProductListing = new HashSet<ProductListing>();
        }

        public int ManufacturerId { get; set; }
        public string Name { get; set; }
        public string AddressLine { get; set; }

        public virtual ICollection<ProductListing> ProductListing { get; set; }
    }
}
