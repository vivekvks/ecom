using Ecom.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;
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
