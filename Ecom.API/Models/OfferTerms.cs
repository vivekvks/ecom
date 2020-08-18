using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class OfferTerms
    {
        public int Id { get; set; }
        public int OfferId { get; set; }
        public string TermText { get; set; }
        public bool IaActive { get; set; }

        public virtual OfferMaster Offer { get; set; }
    }
}
