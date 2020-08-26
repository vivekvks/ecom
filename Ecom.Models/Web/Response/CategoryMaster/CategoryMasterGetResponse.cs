using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models.Web.Response
{
    public class CategoryMasterGetResponse
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public int? ReturnTypeId { get; set; }
    }
}
