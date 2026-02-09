using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record CreateBookManyCommand(IEnumerable<BookDTO> Books) : IRequest<IEnumerable<Book>>;
}
