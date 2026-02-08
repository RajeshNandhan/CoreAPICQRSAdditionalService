using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record DeleteBookCommand(string bookId) : IRequest<long>;
}
