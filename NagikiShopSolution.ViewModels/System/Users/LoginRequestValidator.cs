using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NagikiShopSolution.ViewModels.System.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("User name is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required");

        }
    }
}
