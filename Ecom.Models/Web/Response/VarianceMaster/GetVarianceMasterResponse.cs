using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models.Web.Response
{
    public class GetVarianceMasterResponse
    {
        public int Id { get; set; }
        public string VarianceName { get; set; }
        public bool IncludeInTitle { get; set; }
    }
}
