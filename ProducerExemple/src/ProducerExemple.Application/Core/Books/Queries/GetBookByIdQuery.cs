using MediatR;

namespace ProducerExemple.Application.Core.Books.Queries
{
    public class GetBookByIdQuery : IRequest<BaseResponse>
    {
        public int Id { get; set; }
    }
}
