using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record DeletePersonCommand(string personId) : IRequest<long>;
}
