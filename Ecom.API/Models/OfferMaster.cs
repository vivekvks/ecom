using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class OfferMaster
    {
        public OfferMaster()
        {
            OfferTerms = new HashSet<OfferTerms>();
        }

        public int Id { get; set; }
        public int OfferTypeId { get; set; }
        public int ProductId { get; set; }
        public int Percentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Text { get; set; }
        public double? SharePercentage { get; set; }
        public bool IsActive { get; set; }

        public virtual ProductListing Product { get; set; }
        public virtual ICollection<OfferTerms> OfferTerms { get; set; }
    }
}
