using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record GetPersonsQuery() : IRequest<IEnumerable<Person>>;
}
