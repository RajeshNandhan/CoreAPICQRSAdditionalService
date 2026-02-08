using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record DeletePersonCommand(string personId) : IRequest<long>;
}
