using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record UpdateBookManyCommand(string searchValue, IEnumerable<BookDTO> books) : IRequest<long>;
}
