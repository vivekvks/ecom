using System;
using System.Collections.Generic;

namespace Ecom.Data.Models
{
    public partial class CountryMaster
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
