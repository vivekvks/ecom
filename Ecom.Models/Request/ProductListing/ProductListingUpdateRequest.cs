using System.Text.Json.Serialization;

namespace Ecom.Models.Request
{
    public class ProductListingUpdateRequest
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public int UserId { get; set; }

        public decimal? SellingPrice { get; set; }

        public int? Quantity { get; set; }

        public int? ListingStatus { get; set; }
    }
}
