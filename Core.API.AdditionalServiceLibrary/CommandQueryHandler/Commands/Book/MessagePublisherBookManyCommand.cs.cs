using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record MessagePublisherBookManyCommand(IEnumerable<BookDTO> Books, string messageType, string messageAction, CancellationToken cancellationToken) : IRequest<long>;
}