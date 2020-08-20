using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class CategoryMaster
    {

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public int? ReturnTypeId { get; set; }
    }
}
