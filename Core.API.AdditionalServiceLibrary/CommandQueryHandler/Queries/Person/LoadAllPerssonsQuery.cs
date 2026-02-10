using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record LoadAllPerssonsQuery() : IRequest<IEnumerable<PersonDTO>>;
}
