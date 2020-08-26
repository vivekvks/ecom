﻿namespace Ecom.API.Models
{
    public partial class ProductListing
    {

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

    }
}
