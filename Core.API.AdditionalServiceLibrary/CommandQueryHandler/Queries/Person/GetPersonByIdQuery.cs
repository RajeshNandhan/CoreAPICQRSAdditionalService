using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record GetPersonByIdQuery(string Id) : IRequest<Person>;
}