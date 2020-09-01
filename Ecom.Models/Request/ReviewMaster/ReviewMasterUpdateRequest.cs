using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Ecom.Models.Request
{
    public class ReviewMasterUpdateRequest
    {
        [JsonIgnore]
        public int UserId { get; set; }
        [JsonIgnore]
        public int Id { get; set; }
        public int ProductListingId { get; set; }
        public int Rating { get; set; }
        public string ReviewText { get; set; }
    }
}
