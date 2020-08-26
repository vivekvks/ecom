namespace Ecom.API.Models
{
    public partial class ImageMaster
    {
        public int Id { get; set; }
        public int ProductListingId { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }

        public virtual ProductListing ProductListing { get; set; }
    }
}
