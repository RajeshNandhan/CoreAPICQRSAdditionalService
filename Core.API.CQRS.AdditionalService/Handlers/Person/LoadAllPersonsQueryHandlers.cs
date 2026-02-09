using Core.API.AdditionalServiceLibrary;
using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public class LoadAllPersonsQueryHandlers : IRequestHandler<LoadAllPerssonsQuery, IEnumerable<Person>>
    {
        private readonly IUnitOfWork unitOfWork;

        public LoadAllPersonsQueryHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Person>> Handle(LoadAllPerssonsQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<Person> Persons = DatabaseInitializerPerson.GetPersons();

            var result = await unitOfWork.PersonRepository.CreateEntitiesAsync(Persons, cancellationToken).ConfigureAwait(false);

            if (result > 0)
                return Persons.OrderBy(Person => Person.dateCreated);
            else
                return new List<Person>();
        }
    }
}
