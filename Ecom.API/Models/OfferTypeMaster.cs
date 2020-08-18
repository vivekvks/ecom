using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class OfferTypeMaster
    {
        public int Id { get; set; }
        public string OfferType { get; set; }
        public bool IsActrive { get; set; }
    }
}
