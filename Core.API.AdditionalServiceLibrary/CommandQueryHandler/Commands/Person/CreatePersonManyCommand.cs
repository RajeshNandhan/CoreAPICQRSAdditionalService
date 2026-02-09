using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record CreatePersonManyCommand(IEnumerable<PersonDTO> Persons) : IRequest<IEnumerable<Person>>;
}
