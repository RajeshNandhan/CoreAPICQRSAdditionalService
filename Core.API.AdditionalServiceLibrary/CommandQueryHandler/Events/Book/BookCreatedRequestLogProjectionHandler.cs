using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class BookCreatedRequestLogProjectionHandler : INotificationHandler<BookCreatedEvent>
    {
        public async Task Handle(BookCreatedEvent notification, CancellationToken cancellationToken)
        {
            Logger.LogInformation([ "Book Publish Messaging Queues Requested Log",
                 notification.messageType,
                 notification.messageAction ]);

            await Task.CompletedTask;
        }
    }
}