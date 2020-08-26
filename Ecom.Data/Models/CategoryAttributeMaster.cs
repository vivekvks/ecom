using System;

namespace Ecom.Data.Models
{
    public partial class CategoryAttributeMaster
    {
        public int CategoryAttributeId { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual CategoryMaster Category { get; set; }
    }
}
