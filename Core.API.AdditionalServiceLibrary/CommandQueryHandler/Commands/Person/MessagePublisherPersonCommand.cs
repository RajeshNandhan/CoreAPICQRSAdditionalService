using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record MessagePublisherPersonCommand(Person Person, string messageType, string messageAction, CancellationToken cancellationToken) : IRequest<long>;
}