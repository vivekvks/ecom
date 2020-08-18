using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class CategoryVarianceDetails
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int VarianceMasterId { get; set; }
        public bool IsActive { get; set; }

    }
}
