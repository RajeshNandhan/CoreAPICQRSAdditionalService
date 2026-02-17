using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class PersonManyCreatedProjectionHandler : INotificationHandler<PersonManyCreatedEvent>
    {
        public async Task Handle(PersonManyCreatedEvent notification, CancellationToken cancellationToken)
        {
            foreach (var item in notification.Persons)
            {
                Logger.LogInformation(new string[] {
                    item.isPlayCricket.ToString(),
                    item.firstName.ToString(),
                    item.rank.ToString(),
                    item.isPlayCricket.ToString(),
                    item.category,
                    item.lastName,
                    notification.messageType,
                    notification.messageAction
                });
            }

            await Task.CompletedTask;
        }
    }
}
