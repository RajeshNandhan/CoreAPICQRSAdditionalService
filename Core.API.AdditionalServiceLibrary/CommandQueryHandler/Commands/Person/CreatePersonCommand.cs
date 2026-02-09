using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record CreatePersonCommand(PersonDTO Person) : IRequest<Person>;
}