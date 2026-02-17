using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class PersonCreatedRequestLogProjectionHandler : INotificationHandler<PersonCreatedEvent>
    {
        public async Task Handle(PersonCreatedEvent notification, CancellationToken cancellationToken)
        {
            Logger.LogInformation([ "Person Publish Messaging Queues Requested Log",
                 notification.messageType,
                 notification.messageAction ]);


            await Task.CompletedTask;
        }
    }
}