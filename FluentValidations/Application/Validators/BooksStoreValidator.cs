using FluentValidation;
using FluentValidations.Application.InputModels;

namespace FluentValidations.Application.Validators
{
    public class BooksStoreValidator : AbstractValidator<BooksStoreInputModel>
    {
        public BooksStoreValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .WithMessage("Name must be 3 characters");

            RuleFor(x => x.City)
                .NotEmpty()
                .NotNull()
                .NotEqual("California")
                .MinimumLength(3)
                .WithMessage("City must be 3 characters");
        }
    }
}
