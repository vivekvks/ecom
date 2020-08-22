using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class CompanyMaster
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RegisteredAddressId { get; set; }
        public int PickupAddressId { get; set; }
        public string BusinessName { get; set; }
        public string Gstno { get; set; }
        public string Pan { get; set; }
        public string StoreName { get; set; }
        public string BusinessDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
