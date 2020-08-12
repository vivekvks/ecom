using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class CategoryVarianceDetails
    {
        public int CategoryVarianceId { get; set; }
        public int CategoryId { get; set; }
        public int VarianceMasterId { get; set; }
        public bool IsActive { get; set; }

        public virtual CategoryMaster Category { get; set; }
        public virtual VarianceMaster VarianceMaster { get; set; }
    }
}
