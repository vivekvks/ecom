namespace Ecom.Data.Models
{
    public partial class ListingVarianceDetails
    {
        public int ListingVarianceId { get; set; }
        public int ProductListingId { get; set; }
        public int VarianceMasterId { get; set; }
        public int VarianceValueId { get; set; }
        public bool IsActive { get; set; }

        public virtual ProductListing ProductListing { get; set; }
        public virtual VarianceMaster VarianceMaster { get; set; }
        public virtual VarianceValue VarianceValue { get; set; }
    }
}
