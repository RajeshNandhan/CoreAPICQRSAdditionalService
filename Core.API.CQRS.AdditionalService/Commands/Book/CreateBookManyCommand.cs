using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record CreateBookManyCommand(IEnumerable<BookDTO> Books) : IRequest<IEnumerable<Book>>;
}
