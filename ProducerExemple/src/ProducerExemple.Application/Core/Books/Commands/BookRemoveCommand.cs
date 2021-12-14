using MediatR;

namespace ProducerExemple.Application.Core.Books.Commands
{
    public class BookRemoveCommand : IRequest<BaseResponse>
    {
        public int Id { get; set; }
    }
}
