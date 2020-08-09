using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models.Web.Request
{
    public class CategoryAttributeIn
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }

    }
}
