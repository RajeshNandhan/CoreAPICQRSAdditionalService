using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record UpdateBookManyCommand(string searchValue, IEnumerable<Book> books) : IRequest<long>;
}
