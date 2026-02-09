using Core.API.AdditionalServiceLibrary;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public class DeletePersonManyCommandHandlers : IRequestHandler<DeletePersonManyCommand, long>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeletePersonManyCommandHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<long> Handle(DeletePersonManyCommand request, CancellationToken cancellationToken)
        {
            var result = await unitOfWork.PersonRepository.DeleteEntitiesAsync(cancellationToken).ConfigureAwait(false);
            return result;
        }
    }
}
