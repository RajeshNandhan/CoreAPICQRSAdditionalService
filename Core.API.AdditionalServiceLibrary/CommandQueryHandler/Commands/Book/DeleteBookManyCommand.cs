using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record DeleteBookManyCommand() : IRequest<long>;
}

