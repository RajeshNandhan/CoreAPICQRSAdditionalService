using Core.API.AdditionalServiceLibrary;
using MediatR;

#nullable disable

namespace Core.API.AdditionalServiceLibrary
{
    public class UpdateBookCommandHandlers : IRequestHandler<UpdateBookCommand, long>
    {
        private readonly IUnitOfWork unitOfWork;

        public UpdateBookCommandHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<long> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var book = await unitOfWork.BookRepository.GetEntityByIdAsync(request.bookId, cancellationToken);

            if (book == null)
                return 0;

            var result = await unitOfWork.BookRepository.UpdateAsync(request.bookId, request.book, cancellationToken).ConfigureAwait(false);
            
            return result;
        }
    }
}
