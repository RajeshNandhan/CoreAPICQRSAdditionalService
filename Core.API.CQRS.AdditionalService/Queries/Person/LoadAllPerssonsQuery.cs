using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record LoadAllPerssonsQuery() : IRequest<IEnumerable<Person>>;
}
