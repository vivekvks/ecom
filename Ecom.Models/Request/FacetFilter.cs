using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Ecom.Models.Request
{
    public class FacetFilter
    {
        [JsonProperty("k")]
        public int Key { get; set; }

        [JsonProperty("v")]
        public int[] Value { get; set; }
    }
}
