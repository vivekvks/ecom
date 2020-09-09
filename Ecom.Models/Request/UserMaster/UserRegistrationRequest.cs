using Ecom.Models.Enums;
using FluentValidation;

namespace Ecom.Models.Request
{
    public class UserRegistrationRequest
    {
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public RoleType RoleId { get; set; }
    }

    public class UserRegistrationRequestValidator : AbstractValidator<UserRegistrationRequest>
    {
        public UserRegistrationRequestValidator()
        {
            RuleFor(x => x.Email).NotEmpty().When(x => string.IsNullOrEmpty(x.PhoneNo));
            RuleFor(x => x.Email).EmailAddress().When(x => !string.IsNullOrEmpty(x.Email));
            RuleFor(x => x.PhoneNo).NotEmpty().When(x => string.IsNullOrEmpty(x.Email));
            RuleFor(x => x.Password).NotEmpty().Length(4, 128).When(x => !string.IsNullOrEmpty(x.Email));
            RuleFor(x => x.FirstName).MaximumLength(50);
            RuleFor(x => x.LastName).MaximumLength(50);
            RuleFor(x => x.RoleId).NotEmpty();
        }
    }
}
