using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json.Serialization;

namespace Ecom.Models.Response
{
    public class ProductListingFacetSearchResponse
    {
        public int TotalCount { get; set; }
        public List<ProductListingFacetSearch> Data { get; set; }
        public List<ProductListingFacet> Facet { get; set; }
    }

    public class ProductListingFacetSearch
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string ListingText { get; set; }
        public int CategoryId { get; set; }
        public double MRP { get; set; }
        public double SellingPrice { get; set; }
        public int ListingStatus { get; set; }
        public string ShortDescription { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }

        [JsonIgnore]
        public int TotalCount { get; set; }
    }

    public class ProductListingFacet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Values { get; set; }
    }
}
