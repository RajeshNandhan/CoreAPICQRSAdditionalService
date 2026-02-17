using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class PersonManyCreatedRequestLogProjectionHandler : INotificationHandler<PersonManyCreatedEvent>
    {
        public async Task Handle(PersonManyCreatedEvent notification, CancellationToken cancellationToken)
        {
            Logger.LogInformation([ "Person MANY Publish Messaging Queues Requested Log",
                 notification.messageType,
                 notification.messageAction ]);


            await Task.CompletedTask;
        }
    }
}
