using ProducerExemple.Domain.Entities;
using ProducerExemple.Domain.Interfaces.Repository;

namespace ProducerExemple.Domain.Interfaces
{
    public interface IBookRepository : IBaseRepository<Book, int>
    { }
}
