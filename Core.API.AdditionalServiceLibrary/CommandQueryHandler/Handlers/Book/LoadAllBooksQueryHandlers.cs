using Core.API.AdditionalServiceLibrary;
using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class LoadAllBooksQueryHandlers : IRequestHandler<LoadAllBooksQuery, IEnumerable<Book>>
    {
        private readonly IUnitOfWork unitOfWork;

        public LoadAllBooksQueryHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Book>> Handle(LoadAllBooksQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<Book> books = DatabaseInitializerBook.GetBooks();

            var result = await unitOfWork.BookRepository.CreateEntitiesAsync(books, cancellationToken).ConfigureAwait(false);

            if (result > 0)
                return books.OrderBy(book => book.bookName);
            else
                return new List<Book>();
        }
    }
}
