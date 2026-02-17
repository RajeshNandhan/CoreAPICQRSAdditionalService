using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record BookCreatedEvent(Book Book, string messageType, string messageAction, CancellationToken cancellationToken) : INotification;
}