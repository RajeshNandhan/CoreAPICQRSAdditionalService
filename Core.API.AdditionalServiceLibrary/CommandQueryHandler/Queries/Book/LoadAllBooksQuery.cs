using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record LoadAllBooksQuery() : IRequest<IEnumerable<BookDTO>>;
}
