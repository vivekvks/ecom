using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models.Web.Request
{
    public class CategoryMasterIn
    {
        public int CategoryId { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
    }
}
