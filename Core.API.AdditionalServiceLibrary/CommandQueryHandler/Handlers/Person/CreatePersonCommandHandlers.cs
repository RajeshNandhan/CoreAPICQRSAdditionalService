using Core.API.AdditionalServiceLibrary;
using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class CreatePersonCommandHandlers : IRequestHandler<CreatePersonCommand, Person>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreatePersonCommandHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Person> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            var Person = new Person
            {
                category = request.Person.category,
                dateOfBirth = request.Person.dateOfBirth,
                firstName = request.Person.firstName,
                lastName = request.Person.lastName,
                isPlayCricket = request.Person.isPlayCricket,
                rank = request.Person.rank
            };

            await unitOfWork.PersonRepository.CreateEntityAsync(Person, cancellationToken).ConfigureAwait(false);
            return Person;
        }
    }
}
