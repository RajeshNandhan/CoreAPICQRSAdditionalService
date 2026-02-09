using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record DeletePersonManyCommand() : IRequest<long>;
}

