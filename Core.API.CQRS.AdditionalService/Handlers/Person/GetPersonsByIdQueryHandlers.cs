using Core.API.AdditionalServiceLibrary;
using Core.Library.ArivuTharavuThalam;
using MediatR;

#nullable disable

namespace Core.API.CQRS.AdditionalService
{
    public class GetPersonsByIdQueryHandlers : IRequestHandler<GetPersonByIdQuery, Person>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetPersonsByIdQueryHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Person> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            var Person = await unitOfWork.PersonRepository.GetEntityByIdAsync(request.Id, cancellationToken);
            return Person;
        }
    }
}
