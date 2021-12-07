using ProducerExemple.Domain.Entities;
using ProducerExemple.Domain.Interfaces;
using ProducerExemple.Infra.Data.Context;

namespace ProducerExemple.Infra.Data.Repository.Books
{
    public class BookRepository : BaseRepository<Book, int>, IBookRepository
    {
        public BookRepository(AppDbContext context) : base(context)
        { }
    }
}
