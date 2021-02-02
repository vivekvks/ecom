using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models.Request
{
    public class ProductListingAttributeDetailsRequest
    {
        public int AttributeMasterId { get; set; }
        public int? AttributeValueId { get; set; }
        public string AttributeValue { get; set; }
    }
}
