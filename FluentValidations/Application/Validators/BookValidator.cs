using FluentValidation;
using FluentValidations.Application.InputModels;

namespace FluentValidations.Application.Validators
{
    public class BookValidator : AbstractValidator<BookInputModel>
    {
        public BookValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .WithMessage("Name must be 3 characters");

            RuleFor(x => x.Author)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .WithMessage("Author must be 3 characters");

            RuleFor(x => x.Subject)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .WithMessage("Subject must be 3 characters");

            RuleFor(x => x.Pages)
                .NotNull()
                .GreaterThan(0)
                .WithMessage("Pages must be greater than 0");
        }
    }
}
