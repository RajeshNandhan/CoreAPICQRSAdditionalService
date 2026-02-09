using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class CreatePersonManyCommandHandlers : IRequestHandler<CreatePersonManyCommand, IEnumerable<Person>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMediator mediator;

        public CreatePersonManyCommandHandlers(IUnitOfWork unitOfWork, IMediator mediator)
        {
            this.unitOfWork = unitOfWork;
            this.mediator = mediator;
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

            await mediator.Send(new MessagePublisherPersonManyCommand(request.Persons, MessageTypeConstant.PersonType, MessageActionConstant.Create, cancellationToken), default).ConfigureAwait(false);

            return Persons;
        }
    }
}
