using FluentValidation;
using System;

namespace Ecom.Models.Request
{
    public class OfferMasterAddRequest
    {
        public int OfferTypeId { get; set; }
        public int? ProductId { get; set; }
        public int Percentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Text { get; set; }
        public float SharePercentage { get; set; }
        public int? CategoryId { get; set; }
    }
    public class OfferMasterAddRequestValidator : AbstractValidator<OfferMasterAddRequest>
    {
        public OfferMasterAddRequestValidator()
        {
            RuleFor(x => x.OfferTypeId).NotEmpty();
            RuleFor(x => x.ProductId).NotEmpty().When(x => !x.CategoryId.HasValue);
            RuleFor(x => x.Percentage).NotEmpty().InclusiveBetween(1, 100);
            RuleFor(x => x.StartDate).NotEmpty();
            RuleFor(x => x.EndDate).NotEmpty();
            RuleFor(x => x.Text).NotEmpty();
            RuleFor(x => x.SharePercentage).InclusiveBetween(0, 100);
            RuleFor(x => x.CategoryId).NotEmpty().When(x => !x.ProductId.HasValue);
        }
    }
}
