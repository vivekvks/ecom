using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Ecom.Models.Request
{
    public class QuestionMasterUpdateRequest
    {
        public string QuestionText { get; set; }
        
        [JsonIgnore]
        public int Id { get; set; }
        
        [JsonIgnore]
        public int UserId { get; set; }
    }
}
