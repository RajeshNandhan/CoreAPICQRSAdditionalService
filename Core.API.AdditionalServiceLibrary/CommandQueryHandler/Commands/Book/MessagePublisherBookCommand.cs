using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record MessagePublisherBookCommand(BookDTO Book, string messageType, string messageAction, CancellationToken cancellationToken) : IRequest<long>;
}