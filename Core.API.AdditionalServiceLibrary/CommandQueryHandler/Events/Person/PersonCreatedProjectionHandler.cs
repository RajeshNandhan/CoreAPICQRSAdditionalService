using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class PersonCreatedProjectionHandler : INotificationHandler<PersonCreatedEvent>
    {
        public async Task Handle(PersonCreatedEvent notification, CancellationToken cancellationToken)
        {
            Logger.LogInformation([ "--> Not Connected to any Publish Messaging Queues",
                notification.Person.category,
                notification.Person.lastName,
                notification.Person.isPlayCricket.ToString(),
                notification.Person.firstName.ToString(),
                notification.Person.rank.ToString(),
                notification.Person.isPlayCricket.ToString(),
                notification.messageType,
                notification.messageAction
            ]);

            await Task.CompletedTask;
        }
    }
}