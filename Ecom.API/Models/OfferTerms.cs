namespace Ecom.API.Models
{
    public partial class OfferTerms
    {
        public int Id { get; set; }
        public int OfferId { get; set; }
        public string TermText { get; set; }
        public bool IaActive { get; set; }

    }
}
