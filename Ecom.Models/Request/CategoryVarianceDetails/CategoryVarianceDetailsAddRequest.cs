using FluentValidation;
using System.Collections.Generic;

namespace Ecom.Models.Request
{
    public class CategoryVarianceDetailRequest
    {
        public List<CategoryVarianceDetailsAddRequest> CategoryVarianceDetails { get; set; }
    }

    public class CategoryVarianceDetailsAddRequest
    {
        public int CategoryId { get; set; }
        public int? VarianceMasterId { get; set; }
        public string VarianceMasterName { get; set; }
    }
    public class CategoryVarianceDetailRequestValidator : AbstractValidator<CategoryVarianceDetailRequest>
    {
        public CategoryVarianceDetailRequestValidator()
        {
            RuleForEach(x => x.CategoryVarianceDetails).ChildRules(requests =>
            {
                requests.RuleFor(x => x.CategoryId).NotEmpty();
                requests.RuleFor(x => x.VarianceMasterId).NotEmpty().When(x => string.IsNullOrEmpty(x.VarianceMasterName)).WithMessage("VarianceMasterId {CollectionIndex} is required.");
            });
        }
    }
}
