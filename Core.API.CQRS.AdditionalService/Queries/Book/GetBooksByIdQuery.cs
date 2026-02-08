using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record GetBooksByIdQuery(string bookId) : IRequest<Book>;
}
