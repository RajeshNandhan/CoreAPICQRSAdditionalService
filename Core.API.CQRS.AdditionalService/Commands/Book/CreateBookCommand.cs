using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record CreateBookCommand(BookDTO Book) : IRequest<Book>;
}