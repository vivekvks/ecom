using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models.Request
{
    public class OfferMasterUpdateRequest
    {
        public int OfferTypeId { get; set; }
        public int ProductId { get; set; }
        public int Percentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Text { get; set; }
        public float SharePercentage { get; set; }
    }
    public class OfferMasterUpdateRequestValidator : AbstractValidator<OfferMasterUpdateRequest>
    {
        public OfferMasterUpdateRequestValidator()
        {
            RuleFor(x => x.OfferTypeId).NotEmpty();
            RuleFor(x => x.ProductId).NotEmpty();
            RuleFor(x => x.Percentage).NotEmpty().InclusiveBetween(1, 100);
            RuleFor(x => x.StartDate).NotEmpty();
            RuleFor(x => x.EndDate).NotEmpty();
            RuleFor(x => x.Text).NotEmpty();
            RuleFor(x => x.SharePercentage).InclusiveBetween(0, 100);
        }
    }
}
