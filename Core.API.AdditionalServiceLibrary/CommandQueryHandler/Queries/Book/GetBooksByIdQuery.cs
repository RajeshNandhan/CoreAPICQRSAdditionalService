using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record GetBooksByIdQuery(string Id) : IRequest<BookDTO>;
}
