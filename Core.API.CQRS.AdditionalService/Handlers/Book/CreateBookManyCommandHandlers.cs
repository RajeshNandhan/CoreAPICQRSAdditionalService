using Core.API.AdditionalServiceLibrary;
using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.CQRS.AdditionalService
{
    public class CreateBookManyCommandHandlers : IRequestHandler<CreateBookManyCommand, IEnumerable<Book>>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateBookManyCommandHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Book>> Handle(CreateBookManyCommand request, CancellationToken cancellationToken)
        {
            var books = request.Books.Select(book => new Book
            {
                bookName = book.bookName,
                bookCategory = book.bookCategory,
                edition = book.edition,
                price = book.price,
                image = book.image,
                personId = book.personId
            });

            await unitOfWork.BookRepository.CreateEntitiesAsync(books, cancellationToken).ConfigureAwait(false);
            return books;
        }
    }
}
