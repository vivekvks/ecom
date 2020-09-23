using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models.Response
{
    public class ProductListingLookupResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string ListingText { get; set; }
        public int CategoryId { get; set; }
    }
}
