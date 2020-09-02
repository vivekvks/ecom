using System.Text.Json.Serialization;

namespace Ecom.Models.Request
{
    public class ReviewMasterAddRequest
    {
        [JsonIgnore]
        public int UserId { get; set; }
        public int ProductListingId { get; set; }
        public int Rating { get; set; }
        public string ReviewText { get; set; }
    }
}
