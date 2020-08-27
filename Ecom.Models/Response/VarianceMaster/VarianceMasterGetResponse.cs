using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models.Response.VarianceMaster
{
    public class VarianceMasterGetResponse
    {
        public int Id { get; set; }
        public string VarianceName { get; set; }
        public bool IncludeInTitle { get; set; }
    }
}
