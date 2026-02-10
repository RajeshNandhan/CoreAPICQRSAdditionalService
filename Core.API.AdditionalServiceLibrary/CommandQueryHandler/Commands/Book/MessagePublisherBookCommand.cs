using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record MessagePublisherBookCommand(Book Book, string messageType, string messageAction, CancellationToken cancellationToken) : IRequest<long>;
}