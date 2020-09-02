using Ecom.Models.Enums;
using System.Text.Json.Serialization;

namespace Ecom.Models.Request
{
    public class ReviewReactionRequest
    {
        [JsonIgnore]
        public int UserId { get; set; }

        [JsonIgnore]
        public int Id { get; set; }

        public ReactionType Type { get; set; }
    }
}
