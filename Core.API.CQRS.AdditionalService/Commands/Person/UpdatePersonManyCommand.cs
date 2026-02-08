using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record UpdatePersonManyCommand(string searchValue, IEnumerable<Person> persons) : IRequest<long>;
}
