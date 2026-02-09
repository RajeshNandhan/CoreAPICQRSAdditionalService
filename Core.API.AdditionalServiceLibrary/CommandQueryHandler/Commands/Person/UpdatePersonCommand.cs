using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record UpdatePersonCommand(string personId, Person person) : IRequest<long>;
}
