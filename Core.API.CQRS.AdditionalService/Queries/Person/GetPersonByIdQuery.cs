using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record GetPersonByIdQuery(int Id) : IRequest<Person>;
}