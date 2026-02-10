using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record MessagePublisherPersonManyCommand(IEnumerable<Person> Persons, string messageType, string messageAction, CancellationToken cancellationToken) : IRequest<long>;
}