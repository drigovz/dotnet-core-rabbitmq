using FluentValidation;
using ProducerExemple.Application.Core.Books.Commands;
using ProducerExemple.Domain.Validations;

namespace ProducerExemple.Application.Core.Books.Validators
{
    public class BookCreateCommandValidator : AbstractValidator<BookCreateCommand>
    {
        public BookCreateCommandValidator()
        {
            RuleFor(x => x.Title).Title();
            RuleFor(x => x.Subtitle).Subtitle();
            RuleFor(x => x.Year).Year();
        }
    }
}
