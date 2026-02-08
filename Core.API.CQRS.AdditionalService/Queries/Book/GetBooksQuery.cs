using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record GetBooksQuery() : IRequest<IEnumerable<Book>>;
}
