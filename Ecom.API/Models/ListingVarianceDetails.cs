namespace Ecom.API.Models
{
    public partial class ListingVarianceDetails
    {
        public int Id { get; set; }
        public int ProductListingId { get; set; }
        public int VarianceMasterId { get; set; }
        public int VarianceValueId { get; set; }
        public bool IsActive { get; set; }

    }
}
