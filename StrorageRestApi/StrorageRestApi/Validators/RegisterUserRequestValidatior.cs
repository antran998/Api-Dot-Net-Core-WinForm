using FluentValidation;
using StrorageRestApi.Contracts.v1.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrorageRestApi.Validators
{
    public class RegisterUserRequestValidatior : AbstractValidator<UserRegistrationRequest>
    {
        public RegisterUserRequestValidatior()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .Matches("^([^0-9]+){5,}$")
                .WithMessage("Name must have at least 5 character without number");
            RuleFor(x => x.Email)
                .NotEmpty()
                .Matches("^[a-z][^0][a-z0-9_.-]{3,32}@[a-z0-9]{2,}(.[a-z0-9]{2,4}){1,2}$");
            RuleFor(x => x.Phone)
                .NotEmpty()
                .Matches("^[0][1-9]{9}$");
            RuleFor(x => x.Password)
                .NotEmpty()
                .Matches("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@$!%*?&])[A-Za-z0-9@$!%*?&]{8,}$")
                .WithMessage("Must have: 1 lowercase, 1 uppercase, 1 special char, 1 number");
            RuleFor(x => x.Confirm)
                .NotEmpty()
                .Equal(x => x.Password)
                .WithMessage("Not match with password");

        }
    }
}
