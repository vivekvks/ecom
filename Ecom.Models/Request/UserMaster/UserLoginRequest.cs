﻿using FluentValidation;

namespace Ecom.Models.Request
{
    public class UserLoginRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class UserLoginRequestValidator : AbstractValidator<UserLoginRequest>
    {
        public UserLoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
        }
    }
}
