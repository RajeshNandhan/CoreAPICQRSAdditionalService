using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record UpdatePersonCommand(string personId, Person person) : IRequest<long>;
}
