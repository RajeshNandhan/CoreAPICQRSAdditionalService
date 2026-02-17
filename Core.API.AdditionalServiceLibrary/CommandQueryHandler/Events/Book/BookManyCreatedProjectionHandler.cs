using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class BookManyCreatedProjectionHandler : INotificationHandler<BookManyCreatedEvent>
    {
        public async Task Handle(BookManyCreatedEvent notification, CancellationToken cancellationToken)
        {
            foreach (var item in notification.Books)
            {
                Logger.LogInformation(new string[] {
                    item.bookName,
                    item.bookCategory,
                    item.edition.ToString(),
                    item.price.ToString(),
                    item.image,
                    notification.messageType,
                    notification.messageAction
                });
            }

            await Task.CompletedTask;
        }
    }
}