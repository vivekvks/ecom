using System;
using System.Collections.Generic;

namespace Ecom.Data.Models
{
    public partial class TaxMaster
    {
        public int TaxId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public double Value { get; set; }
    }
}
