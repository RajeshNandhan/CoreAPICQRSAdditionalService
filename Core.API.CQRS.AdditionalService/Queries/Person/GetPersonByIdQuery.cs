using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record GetPersonByIdQuery(string Id) : IRequest<Person>;
}