using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class CreatePersonCommandHandlers : IRequestHandler<CreatePersonCommand, PersonDTO>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMediator mediator;

        public CreatePersonCommandHandlers(IUnitOfWork unitOfWork, IMediator mediator)
        {
            this.unitOfWork = unitOfWork;
            this.mediator = mediator;
        }

        public async Task<PersonDTO> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            var Person = PersonMapper.PersonCreateDTOToPerson(request.Person);

            var result = await unitOfWork.PersonRepository.CreateEntityAsync(Person, cancellationToken).ConfigureAwait(false);

            await mediator.Send(new MessagePublisherPersonCommand(result, MessageTypeConstant.PersonType, MessageActionConstant.Create, cancellationToken), default).ConfigureAwait(false);

            return PersonMapper.PersonToPersonDTO(result);
        }
    }
}
