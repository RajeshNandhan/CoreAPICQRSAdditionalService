using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record DeleteBookManyCommand() : IRequest<long>;
}

