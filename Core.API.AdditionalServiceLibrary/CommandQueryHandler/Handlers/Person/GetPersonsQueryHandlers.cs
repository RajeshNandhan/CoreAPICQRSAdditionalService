using Core.API.AdditionalServiceLibrary;
using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class GetPersonsQueryHandlers : IRequestHandler<GetPersonsQuery, IEnumerable<Person>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetPersonsQueryHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Person>> Handle(GetPersonsQuery request, CancellationToken cancellationToken)
        {
            var Persons = await unitOfWork.PersonRepository.GetEntitiesAsync(cancellationToken);

            return Persons.OrderBy(Person => Person.dateCreated);
        }
    }
}
