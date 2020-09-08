using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models.Request.OfferMaster
{
    public class OfferMasterAddRequest
    {
        public int OfferTypeId { get; set; }
        public int ProductId { get; set; }
        public int Percentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Text { get; set; }
        public float SharePercentage { get; set; }
    }
}
