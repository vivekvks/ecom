using FluentValidation;
using System.Collections.Generic;
using System.Linq;

namespace Ecom.Models.Request
{
    public class ProductListingRequest
    {
        public List<ProductListingAddRequest> ProductListings { get; set; }
    }
    public class ProductListingAddRequest
    {
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string SellerSKU { get; set; }
        public bool ListingStatus { get; set; }
        public string Title { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public int ShppingId { get; set; }
        public double? MRP { get; set; }
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
        public string ManufacturingName { get; set; }
        public string ImpoterName { get; set; }
        public string ParentListingText { get; set; }
        public string Hsncode { get; set; }
        public int Quantity { get; set; }
        public int MaxOrderQuantity { get; set; }

        public List<ProductListingVarianceDetailsRequest> ProductListingVarianceDetails { get; set; }

        public List<ProductListingAttributeDetailsRequest> ProductListingAttributeDetails { get; set; }
    }

    public class ProductListingRequestValidator : AbstractValidator<ProductListingRequest>
    {
        public ProductListingRequestValidator()
        {
            RuleForEach(x => x.ProductListings).SetValidator(new ProductListingAddRequestValidator());
        }
    }
    public class ProductListingAddRequestValidator : AbstractValidator<ProductListingAddRequest>
    {
        public ProductListingAddRequestValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
            RuleFor(x => x.CategoryId).NotEmpty();
            RuleFor(x => x.SellerSKU).NotEmpty();
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.BrandName).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            //RuleFor(x => x.ShortDescription).NotEmpty();
            RuleFor(x => x.ShppingId).NotEmpty();
            //RuleFor(x => x.MRP).NotEmpty();
            RuleFor(x => x.SellingPrice).NotEmpty();
            //RuleFor(x => x.DeliveryLocal).NotEmpty();
            //RuleFor(x => x.DeliveryZonal).NotEmpty();
            //RuleFor(x => x.DeliveryNational).NotEmpty();
            RuleFor(x => x.Length).NotEmpty();
            RuleFor(x => x.Width).NotEmpty();
            RuleFor(x => x.Height).NotEmpty();
            RuleFor(x => x.Weight).NotEmpty();
            RuleFor(x => x.TaxId).NotEmpty();
            RuleFor(x => x.CountryId).NotEmpty();
            //RuleFor(x => x.ManufacturingName).NotEmpty();
            //RuleFor(x => x.ImpoterName).NotEmpty();
            //RuleFor(x => x.Hsncode).NotEmpty();
            //RuleFor(x => x.Quantity).NotEmpty();
            RuleFor(x => x.MaxOrderQuantity).NotEmpty();
            RuleForEach(x => x.ProductListingVarianceDetails).SetValidator(new ProductListingVarianceDetailsRequestValidator());
            RuleForEach(x => x.ProductListingAttributeDetails).SetValidator(new ProductListingAttributeDetailsRequestValidator());

            RuleFor(x => x.ProductListingAttributeDetails)
                .Must(CheckDuplicateAttributeId)
                .When(x => x.ProductListingAttributeDetails != null)
                .WithMessage("Duplicate attribute not allowed");
        }

        private bool CheckDuplicateAttributeId(List<ProductListingAttributeDetailsRequest> attributeDetailsRequests)
        {
            return !attributeDetailsRequests.GroupBy(x => x.AttributeMasterId).Where(grp => grp.Count() > 1).Any();
        }
    }

    public class ProductListingVarianceDetailsRequestValidator : AbstractValidator<ProductListingVarianceDetailsRequest>
    {
        public ProductListingVarianceDetailsRequestValidator()
        {
            RuleFor(x => x.VarianceMasterId).NotEmpty();
            RuleFor(x => x.VarianceValueId).NotEmpty().When(x => string.IsNullOrEmpty(x.VarianceValue));
        }
    }

    public class ProductListingAttributeDetailsRequestValidator : AbstractValidator<ProductListingAttributeDetailsRequest>
    {
        public ProductListingAttributeDetailsRequestValidator()
        {
            RuleFor(x => x.AttributeMasterId).NotEmpty();
            RuleFor(x => x.AttributeValueId).NotEmpty().When(x => string.IsNullOrEmpty(x.AttributeValue));
        }
    }
}