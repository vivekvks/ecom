using FluentValidation;

namespace Ecom.Models.Request
{
    public class CategoryVarianceDetailsAddRequest
    {
        public int CategoryId { get; set; }
        public int? VarianceMasterId { get; set; }
        public string VarianceMasterName { get; set; }
    }
    public class CategoryVarianceDetailsAddRequestValidator : AbstractValidator<CategoryVarianceDetailsAddRequest>
    {
        public CategoryVarianceDetailsAddRequestValidator()
        {

        }
    }
}
