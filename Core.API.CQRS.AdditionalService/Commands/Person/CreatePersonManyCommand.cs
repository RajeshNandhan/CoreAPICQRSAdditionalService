using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record CreatePersonManyCommand(IEnumerable<PersonDTO> Persons) : IRequest<IEnumerable<Person>>;
}
