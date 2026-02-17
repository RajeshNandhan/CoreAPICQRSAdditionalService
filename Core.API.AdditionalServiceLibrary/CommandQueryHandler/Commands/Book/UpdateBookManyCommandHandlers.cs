using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
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
            var books = request.books.Select(book => BookMapper.BookDTOToBook(book));
            var result = await unitOfWork.BookRepository.UpdateManyAsync(books, cancellationToken).ConfigureAwait(false);
            return result;
        }
    }
}
