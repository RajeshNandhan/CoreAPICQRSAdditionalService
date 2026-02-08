using Core.API.AdditionalServiceLibrary;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public class DeleteBookManyCommandHandlers : IRequestHandler<DeleteBookManyCommand, long>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteBookManyCommandHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<long> Handle(DeleteBookManyCommand request, CancellationToken cancellationToken)
        {
            var result = await unitOfWork.BookRepository.DeleteEntitiesAsync(cancellationToken).ConfigureAwait(false);
            return result;
        }
    }
}
