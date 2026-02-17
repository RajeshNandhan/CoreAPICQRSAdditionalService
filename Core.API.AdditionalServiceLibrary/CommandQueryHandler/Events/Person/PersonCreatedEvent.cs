using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record PersonCreatedEvent(Person Person, string messageType, string messageAction, CancellationToken cancellationToken) : INotification;
}