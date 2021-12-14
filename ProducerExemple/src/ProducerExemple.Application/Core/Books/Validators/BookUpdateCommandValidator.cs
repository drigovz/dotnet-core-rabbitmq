using FluentValidation;
using ProducerExemple.Application.Core.Books.Commands;
using ProducerExemple.Domain.Validations;

namespace ProducerExemple.Application.Core.Books.Validators
{
    public class BookUpdateCommandValidator : AbstractValidator<BookUpdateCommand>
    {
        public BookUpdateCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Title).Title();
            RuleFor(x => x.Subtitle).Subtitle();
            RuleFor(x => x.Year).Year();
        }
    }
}
