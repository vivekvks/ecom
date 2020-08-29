using FluentValidation;
using System.Data;

namespace Ecom.Models.Request
{
    public class CategoryMasterAddRequest
    {
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public int ReturnTypeId { get; set; }
    }
    public class CategoryMasterAddRequestValidator : AbstractValidator<CategoryMasterAddRequest>
    {
        public CategoryMasterAddRequestValidator()
        {
            RuleFor(categoryMaster => categoryMaster.Name).NotEmpty();
            RuleFor(categoryMaster => categoryMaster.ReturnTypeId).NotEmpty();
        }
    }
}
