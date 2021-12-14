using MediatR;

namespace ProducerExemple.Application.Core.Books.Commands
{
    public class BookCommand : IRequest<BaseResponse>
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Year { get; set; }
    }
}
