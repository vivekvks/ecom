using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Data.Models
{
    public class CategoryReturnMaster
    {
        public int Id { get; set; }
        public int NoOfDays { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
