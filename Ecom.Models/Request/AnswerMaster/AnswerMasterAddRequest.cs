using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Ecom.Models.Request
{
    public class AnswerMasterAddRequest
    {
        [JsonIgnore]
        public int UserId { get; set; }

        public int QuestionId { get; set; }

        public string AnswerText { get; set; }
    }
}
