using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record MessagePublisherBookManyCommand(IEnumerable<Book> Books, string messageType, string messageAction, CancellationToken cancellationToken) : IRequest<long>;
}