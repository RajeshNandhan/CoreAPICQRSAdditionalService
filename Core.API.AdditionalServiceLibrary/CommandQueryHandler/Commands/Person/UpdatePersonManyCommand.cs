using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record UpdatePersonManyCommand(string searchValue, IEnumerable<Person> persons) : IRequest<long>;
}
