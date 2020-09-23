using FluentValidation;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Ecom.Models.Request
{
    public class OrderMasterAddRequest
    {
        public int ShippingAddressId { get; set; }
        public int BillingAddressId { get; set; }
        public int UserId { get; set; }
        public List<OrderProductDetailsRequest> OrderProductDetails { get; set; }
        public class OrderProductDetailsRequest
        {
            public int ProductId { get; set; }
        }
    }
    public class OrderMasterAddRequestValidator : AbstractValidator<OrderMasterAddRequest>
    {
        public OrderMasterAddRequestValidator()
        {
            RuleForEach(x => x.OrderProductDetails).SetValidator(new OrderProductDetailsRequestValidator());
        }
    }
    public class OrderProductDetailsRequestValidator : AbstractValidator<OrderMasterAddRequest.OrderProductDetailsRequest>
    {
        public OrderProductDetailsRequestValidator()
        {
            RuleFor(x => x.ProductId).NotEmpty();
        }
    }
}
