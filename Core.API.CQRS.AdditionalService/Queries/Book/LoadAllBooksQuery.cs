using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record LoadAllBooksQuery() : IRequest<IEnumerable<Book>>;
}
