using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record UpdateBookManyCommand(string searchValue, IEnumerable<Book> books) : IRequest<long>;
}
