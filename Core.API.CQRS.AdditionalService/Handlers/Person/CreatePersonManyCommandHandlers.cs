using Core.API.AdditionalServiceLibrary;
using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public class CreatePersonManyCommandHandlers : IRequestHandler<CreatePersonManyCommand, IEnumerable<Person>>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreatePersonManyCommandHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Person>> Handle(CreatePersonManyCommand request, CancellationToken cancellationToken)
        {
            var Persons = request.Persons.Select(Person => new Person
            {
                category = Person.category,
                dateOfBirth = Person.dateOfBirth,
                firstName = Person.firstName,
                lastName = Person.lastName,
                isPlayCricket = Person.isPlayCricket,
                rank = Person.rank
            });

            await unitOfWork.PersonRepository.CreateEntitiesAsync(Persons, cancellationToken).ConfigureAwait(false);
            return Persons;
        }
    }
}
