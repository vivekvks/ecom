using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class CategoryReturnMaster
    {
        
        public int Id { get; set; }
        public int NoOfDays { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

    }
}
