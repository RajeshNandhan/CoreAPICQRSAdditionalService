using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record UpdatePersonCommand(string personId, PersonDTO person) : IRequest<long>;
}
