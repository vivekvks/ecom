using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models.Web.Request
{
    public class AddCategoryMasterRequest
    {
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public int ReturnTypeId { get; set; }
    }
}
