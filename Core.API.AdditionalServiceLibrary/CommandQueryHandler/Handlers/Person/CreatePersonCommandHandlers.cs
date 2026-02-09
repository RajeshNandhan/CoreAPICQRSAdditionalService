using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class CreatePersonCommandHandlers : IRequestHandler<CreatePersonCommand, Person>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMediator mediator;

        public CreatePersonCommandHandlers(IUnitOfWork unitOfWork, IMediator mediator)
        {
            this.unitOfWork = unitOfWork;
            this.mediator = mediator;
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

            await mediator.Send(new MessagePublisherPersonCommand(request.Person, MessageTypeConstant.PersonType, MessageActionConstant.Create, cancellationToken), default).ConfigureAwait(false);

            return Person;
        }
    }
}
