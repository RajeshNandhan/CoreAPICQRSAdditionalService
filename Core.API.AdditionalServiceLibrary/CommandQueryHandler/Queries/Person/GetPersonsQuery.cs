using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record GetPersonsQuery() : IRequest<IEnumerable<PersonDTO>>;
}
