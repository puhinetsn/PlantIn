using FluentValidation;
using PlantInAPI.src.User.DTOs;

namespace PlantInAPI.src.User.Validation
{
    public class UserValidator : AbstractValidator<UserCreateRequestDTO>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Email is required.")
                .MaximumLength(254).WithMessage("Email must not exceed 254 characters.")
                .EmailAddress().WithMessage("Email format is invalid.");

            RuleFor(x => x.Password)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(8).WithMessage("Password must be at least 8 characters long.")
                .MaximumLength(128).WithMessage("Password must not exceed 128 characters.");

            RuleFor(x => x.Name)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Name is required.")
                .MinimumLength(2).WithMessage("Name must be at least 2 characters long.")
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters.")
                .Matches(@"^[\p{L}\p{M}' \-\.]+$")
                    .WithMessage("Name contains invalid characters.");
        }
    }
}