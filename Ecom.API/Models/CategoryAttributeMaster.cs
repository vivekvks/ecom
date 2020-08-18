using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class CategoryAttributeMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}
