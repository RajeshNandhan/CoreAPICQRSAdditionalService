using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public record CreatePersonCommand(PersonDTO Person) : IRequest<Person>;
}