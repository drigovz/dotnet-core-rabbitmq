using FluentValidation;
using ProducerExemple.Domain.Entities;

namespace ProducerExemple.Domain.Validations.Books
{
    public class BookValidations : AbstractValidator<Book>
    {
        public BookValidations()
        {
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.Subtitle).NotEmpty();
            RuleFor(x => x.Year).NotEmpty();
        }
    }
}
