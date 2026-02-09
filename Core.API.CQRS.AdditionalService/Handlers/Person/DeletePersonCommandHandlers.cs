using Core.API.AdditionalServiceLibrary;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public class DeletePersonCommandHandlers : IRequestHandler<DeletePersonCommand, long>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeletePersonCommandHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<long> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {
            var result = await unitOfWork.PersonRepository.DeleteEntityByIdAsync(request.personId, cancellationToken).ConfigureAwait(false);
            return result;
        }
    }
}
