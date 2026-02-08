using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record DeletePersonManyCommand() : IRequest<long>;
}

