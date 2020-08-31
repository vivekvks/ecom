using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Ecom.Models.Request
{
    public class AnswerLikeUnLikeRequest
    {
        public bool IsLike { get; set; }

        [JsonIgnore]
        public int UserId { get; set; }
    }
}
