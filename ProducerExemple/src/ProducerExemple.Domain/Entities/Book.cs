using ProducerExemple.Domain.Validations.Books;

namespace ProducerExemple.Domain.Entities
{
    public sealed class Book : BaseEntity
    {
        public string Title { get; private set; }
        public string Subtitle { get; private set; }
        public int Year { get; private set; }

        public Book(int id, string title, string subtitle, int year)
        {
            Id = id;

            Validate(this, new BookValidations());
        }

        public Book(string title, string subtitle, int year)
        {
            Title = title;
            Subtitle = subtitle;
            Year = year;

            Validate(this, new BookValidations());
        }

        public Book Update(string title, string subtitle, int year)
        {
            Title = title;
            Subtitle = subtitle;
            Year = year;

            Validate(this, new BookValidations());

            return this;
        }
    }
}
