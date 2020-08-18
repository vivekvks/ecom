using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class ProductListing
    {
        public ProductListing()
        {
            ImageMaster = new HashSet<ImageMaster>();
            ListingVarianceDetails = new HashSet<ListingVarianceDetails>();
            OfferMaster = new HashSet<OfferMaster>();
            QuestionMaster = new HashSet<QuestionMaster>();
            ReviewMaster = new HashSet<ReviewMaster>();
        }

        public int Id { get; set; }
        public string ListingText { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string SellerSku { get; set; }
        public bool ListingStatus { get; set; }
        public string Title { get; set; }
        public int BrandId { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public int ShppingId { get; set; }
        public double? Mrp { get; set; }
        public double SellingPrice { get; set; }
        public double? DeliveryLocal { get; set; }
        public double? DeliveryZonal { get; set; }
        public double? DeliveryNational { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int TaxId { get; set; }
        public int CountryId { get; set; }
        public int? ManufacturingId { get; set; }
        public int? ImpoterId { get; set; }
        public string ParentListingText { get; set; }
        public string Hsncode { get; set; }
        public int Quantity { get; set; }
        public int MaxOrderQuantity { get; set; }
        public string VarianceJson { get; set; }

        public virtual ImpoterMaster Impoter { get; set; }
        public virtual ManufacturingMaster Manufacturing { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<ImageMaster> ImageMaster { get; set; }
        public virtual ICollection<ListingVarianceDetails> ListingVarianceDetails { get; set; }
        public virtual ICollection<OfferMaster> OfferMaster { get; set; }
        public virtual ICollection<QuestionMaster> QuestionMaster { get; set; }
        public virtual ICollection<ReviewMaster> ReviewMaster { get; set; }
    }
}
