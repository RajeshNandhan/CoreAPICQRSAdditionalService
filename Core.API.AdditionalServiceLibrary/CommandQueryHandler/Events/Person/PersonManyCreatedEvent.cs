using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record PersonManyCreatedEvent(IEnumerable<Person> Persons, string messageType, string messageAction, CancellationToken cancellationToken) : INotification;
}
