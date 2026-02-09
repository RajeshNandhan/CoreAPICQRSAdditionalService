using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record GetBooksQuery() : IRequest<IEnumerable<Book>>;
}
