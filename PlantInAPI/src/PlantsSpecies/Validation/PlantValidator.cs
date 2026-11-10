using FluentValidation;
using PlantInAPI.src.PlantsSpecies.Models;

namespace PlantInAPI.src.PlantsSpecies.Validation
{
    public class PlantValidator: AbstractValidator<PlantSpecies>
    {
        public void CustomerValidator()
        {
            RuleFor(x => x.CommonName)
            .NotEmpty().WithMessage("Common name is required.")
            .MaximumLength(150).WithMessage("Common name must not exceed 150 characters.")
            .Must(NotBeBlankOrPadded).WithMessage("Common name must not start or end with spaces.");

            RuleFor(x => x.LatinName)
                .NotEmpty().WithMessage("Latin name is required.")
                .MaximumLength(200).WithMessage("Latin name must not exceed 200 characters.")
                .Matches(@"^[A-Z][a-z]+ [a-z][a-z\-]+( .+)?$")
                    .WithMessage("Latin name must follow binomial format, e.g. 'Monstera deliciosa'.");

            RuleFor(x => x.AlternativeNames)
                .MaximumLength(100).WithMessage("Alternative names must not exceed 100 characters.")
                .When(x => x.AlternativeNames is not null);

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Description must not exceed 500 characters.")
                .When(x => x.Description is not null);
        }

        private static bool NotBeBlankOrPadded(string value) =>
        value == value.Trim();
    }
}
