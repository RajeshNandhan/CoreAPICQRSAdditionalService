using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class BookCreatedProjectionHandler : INotificationHandler<BookCreatedEvent>
    {
        public async Task Handle(BookCreatedEvent notification, CancellationToken cancellationToken)
        {
            Logger.LogInformation(new string[] { "--> Not Connected to any Publish Messaging Queues",
                notification.Book.bookName,
                notification.Book.bookCategory,
                notification.Book.edition.ToString(),
                notification.Book.price.ToString(),
                notification.Book.image,
                notification.messageType,
                notification.messageAction
            });

            await Task.CompletedTask;
        }
    }
}