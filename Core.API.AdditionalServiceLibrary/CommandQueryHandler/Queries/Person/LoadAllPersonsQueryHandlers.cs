using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class LoadAllPersonsQueryHandlers : IRequestHandler<LoadAllPerssonsQuery, IEnumerable<PersonDTO>>
    {
        private readonly IUnitOfWork unitOfWork;

        public LoadAllPersonsQueryHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<PersonDTO>> Handle(LoadAllPerssonsQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<Person> Persons = DatabaseInitializerPerson.GetPersons();

            var result = await unitOfWork.PersonRepository.CreateEntitiesAsync(Persons, cancellationToken).ConfigureAwait(false);

            if (result?.Any() == true)
                return result.Select(PersonMapper.PersonToPersonDTO);
            else
                return new List<PersonDTO>();
        }
    }
}
