using System;
using System.Collections.Generic;

namespace Ecom.Data.Models
{
    public partial class ShippingType
    {
        public int ShippingId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
