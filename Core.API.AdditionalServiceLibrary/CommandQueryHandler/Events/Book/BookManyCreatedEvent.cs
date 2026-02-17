using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record BookManyCreatedEvent(IEnumerable<Book> Books, string messageType, string messageAction, CancellationToken cancellationToken) : INotification;
}