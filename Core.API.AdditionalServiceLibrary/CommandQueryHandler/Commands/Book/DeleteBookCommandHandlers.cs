using Core.API.AdditionalServiceLibrary;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class DeleteBookCommandHandlers : IRequestHandler<DeleteBookCommand, long>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteBookCommandHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<long> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var result = await unitOfWork.BookRepository.DeleteEntityByIdAsync(request.bookId, cancellationToken).ConfigureAwait(false);
            return result;
        }
    }
}
