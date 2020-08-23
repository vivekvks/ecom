using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Ecom.Models.Web.Request
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
