using FluentValidation;
using PlantInAPI.src.PlantsSpecies.DTOs;

namespace PlantInAPI.src.PlantsSpecies.Validation
{
    public class PlantValidator : AbstractValidator<PlantRequestDTO>
    {
        public PlantValidator()
        {
            RuleFor(x => x.CommonName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Common name is required.")
                .MaximumLength(150).WithMessage("Common name must not exceed 150 characters.")
                .Must(NotBePadded).WithMessage("Common name must not start or end with spaces.");

            RuleFor(x => x.LatinName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Latin name is required.")
                .MaximumLength(200).WithMessage("Latin name must not exceed 200 characters.")
                .Matches(@"^[A-Z][a-z]+ [a-z][a-z\-]+( .+)?$")
                    .WithMessage("Latin name must follow binomial format, e.g. 'Monstera deliciosa'.");

            RuleFor(x => x.AlternativeNames)
                .MaximumLength(1000).WithMessage("Alternative names must not exceed 1000 characters.");

            RuleFor(x => x.Description)
                .MaximumLength(5000).WithMessage("Description must not exceed 5000 characters.");

            RuleFor(x => x.Toxicity)
                .IsInEnum().WithMessage("Toxicity level is invalid.");

            RuleFor(x => x.Sunlight)
               .IsInEnum().WithMessage("Sunlight level is invalid.");

            RuleFor(x => x.PotSize)
                .InclusiveBetween(1, 100).WithMessage("Pot size must be between 1 and 100.");

            RuleFor(x => x.Soil)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Soul is required.")
                .MaximumLength(200).WithMessage("Soul must not exceed 200 characters.");

            RuleFor(x => x.Temperature)
                .InclusiveBetween(0, 45).WithMessage("Temperature must be between 0 and 45.");

            RuleFor(x => x.TypicalProblems)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("Typical problems list is required (it can be empty).")
                .Must(a => a.Length <= 20).WithMessage("At most 20 typical problems are allowed.");

            RuleForEach(x => x.TypicalProblems)
                .NotEmpty().WithMessage("Typical problem must not be empty.")
                .MaximumLength(200).WithMessage("Each typical problem must not exceed 200 characters.");
        }

        private static bool NotBePadded(string value) => value == value.Trim();
    }
}