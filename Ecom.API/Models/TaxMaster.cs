using System;

namespace Ecom.API.Models
{
    public partial class TaxMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public double Value { get; set; }
    }
}
