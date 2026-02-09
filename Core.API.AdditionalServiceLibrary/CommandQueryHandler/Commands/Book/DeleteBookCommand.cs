using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record DeleteBookCommand(string bookId) : IRequest<long>;
}
