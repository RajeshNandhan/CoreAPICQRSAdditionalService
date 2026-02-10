using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class CreatePersonManyCommandHandlers : IRequestHandler<CreatePersonManyCommand, IEnumerable<PersonDTO>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMediator mediator;

        public CreatePersonManyCommandHandlers(IUnitOfWork unitOfWork, IMediator mediator)
        {
            this.unitOfWork = unitOfWork;
            this.mediator = mediator;
        }

        public async Task<IEnumerable<PersonDTO>> Handle(CreatePersonManyCommand request, CancellationToken cancellationToken)
        {
            var Persons = request.Persons.Select(PersonMapper.PersonCreateDTOToPerson);

            var result = await unitOfWork.PersonRepository.CreateEntitiesAsync(Persons, cancellationToken).ConfigureAwait(false);

            await mediator.Send(new MessagePublisherPersonManyCommand(result, MessageTypeConstant.PersonType, MessageActionConstant.Create, cancellationToken), default).ConfigureAwait(false);

            return result.Select(PersonMapper.PersonToPersonDTO);
        }
    }
}
