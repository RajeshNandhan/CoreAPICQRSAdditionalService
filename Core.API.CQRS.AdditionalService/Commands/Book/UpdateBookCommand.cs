using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record UpdateBookCommand(string bookId, Book book) : IRequest<long>;
}
