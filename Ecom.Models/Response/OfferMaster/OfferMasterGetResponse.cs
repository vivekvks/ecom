using System;

namespace Ecom.Models.Response
{
    public class OfferMasterGetResponse
    {
        public int Id { get; set; }
        public int OfferTypeId { get; set; }
        public int ProductId { get; set; }
        public int Percentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Text { get; set; }
        public float SharePercentage { get; set; }
    }
}
