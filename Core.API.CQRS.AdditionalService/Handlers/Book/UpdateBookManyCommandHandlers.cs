using Core.API.AdditionalServiceLibrary;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public class UpdateBookManyCommandHandlers : IRequestHandler<UpdateBookManyCommand, long>
    {
        private readonly IUnitOfWork unitOfWork;

        public UpdateBookManyCommandHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<long> Handle(UpdateBookManyCommand request, CancellationToken cancellationToken)
        {
            var result = await unitOfWork.BookRepository.UpdateManyAsync(books => true, request.books, cancellationToken).ConfigureAwait(false);
            return result;
        }
    }
}
