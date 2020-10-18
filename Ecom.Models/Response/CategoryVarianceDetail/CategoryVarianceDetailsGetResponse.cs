using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models.Response
{
    public class CategoryVarianceDetailsGetResponse
    {
        public string VarianceName { get; set; }
        public int Id { get; set; }
        public bool IncludeInTitle { get; set; }
    }
}
