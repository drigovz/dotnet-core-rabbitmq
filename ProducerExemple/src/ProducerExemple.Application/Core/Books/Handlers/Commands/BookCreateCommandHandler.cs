using MediatR;
using ProducerExemple.Application.Core.Books.Commands;
using ProducerExemple.Application.Notifications;
using ProducerExemple.Domain.Entities;
using ProducerExemple.Domain.Interfaces;

namespace ProducerExemple.Application.Core.Books.Handlers.Commands
{
    public class BookCreateCommandHandler : IRequestHandler<BookCreateCommand, BaseResponse>
    {
        private readonly IBookRepository _repository;
        private readonly NotificationContext _notification;

        public BookCreateCommandHandler(IBookRepository repository, NotificationContext notification)
        {
            _repository = repository;
            _notification = notification;
        }

        public async Task<BaseResponse> Handle(BookCreateCommand request, CancellationToken cancellationToken)
        {
            var book = new Book(request.Title, request.Subtitle, request.Year);
            if (!book.Valid)
            {
                _notification.AddNotifications(book.ValidationResult);

                return new BaseResponse
                {
                    Notifications = _notification.Notifications,
                };
            }

            var result = await _repository.AddAsync(book);
            if (result == null)
            {
                _notification.AddNotification("Error", "Error When try to add new book!");

                return new BaseResponse
                {
                    Notifications = _notification.Notifications,
                };
            }

            return new BaseResponse
            {
                Result = result,
            };
        }
    }
}
