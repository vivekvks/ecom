using System.Text.Json.Serialization;

namespace Ecom.Models.Response
{
    public class ProductListingResponse
    {
        public int Id { get; set; }
        public string ListingText { get; set; }
        public string SellerSKU { get; set; }
        public string Title { get; set; }
        public double MRP { get; set; }
        public double SellingPrice { get; set; }
        public int ListingStatus { get; set; }
        [JsonIgnore]
        public int TotalCount { get; set; }
    }
}
