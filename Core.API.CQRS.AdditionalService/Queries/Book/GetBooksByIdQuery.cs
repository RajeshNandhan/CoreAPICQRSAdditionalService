using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record GetBooksByIdQuery(string Id) : IRequest<Book>;
}
