using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class BookManyCreatedRequestLogProjectionHandler : INotificationHandler<BookManyCreatedEvent>
    {
        public async Task Handle(BookManyCreatedEvent notification, CancellationToken cancellationToken)
        {
            Logger.LogInformation([ "Book MANY Publish Messaging Queues Requested Log",
                 notification.messageType,
                 notification.messageAction ]);

            await Task.CompletedTask;
        }
    }
}