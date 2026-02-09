using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record MessagePublisherPersonCommand(PersonDTO Person, string messageType, string messageAction, CancellationToken cancellationToken) : IRequest<long>;
}