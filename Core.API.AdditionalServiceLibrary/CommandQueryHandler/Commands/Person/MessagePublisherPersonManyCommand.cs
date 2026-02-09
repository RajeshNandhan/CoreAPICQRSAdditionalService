using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record MessagePublisherPersonManyCommand(IEnumerable<PersonDTO> Persons, string messageType, string messageAction, CancellationToken cancellationToken) : IRequest<long>;
}