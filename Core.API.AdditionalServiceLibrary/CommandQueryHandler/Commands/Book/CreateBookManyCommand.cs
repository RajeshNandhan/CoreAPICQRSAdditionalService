using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record CreateBookManyCommand(IEnumerable<BookCreateDTO> Books) : IRequest<IEnumerable<BookDTO>>;
}
