using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record CreatePersonManyCommand(IEnumerable<PersonCreateDTO> Persons) : IRequest<IEnumerable<PersonDTO>>;
}
