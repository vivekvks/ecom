using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models.Request
{
    public class ProductListingVarianceDetailsRequest
    {
        public int VarianceMasterId { get; set; }
        public int? VarianceValueId { get; set; }
        public string VarianceValue { get; set; }
    }
}
