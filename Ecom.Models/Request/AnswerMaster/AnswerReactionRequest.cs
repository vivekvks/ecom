using Ecom.Models.Enums;
using System.Text.Json.Serialization;

namespace Ecom.Models.Request
{
    public class AnswerReactionRequest
    {
        public ReactionType Type { get; set; }

        [JsonIgnore]
        public int UserId { get; set; }

        [JsonIgnore]
        public int Id { get; set; }
    }
}
