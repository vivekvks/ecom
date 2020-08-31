using System.Text.Json.Serialization;

namespace Ecom.Models.Request
{
    public class QuestionMasterAddRequest
    {
        public string QuestionText { get; set; }

        public int ProductListingId { get; set; }

        [JsonIgnore]
        public int UserId { get; set; }
    }
}
