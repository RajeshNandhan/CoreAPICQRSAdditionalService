using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class LoadAllBooksQueryHandlers : IRequestHandler<LoadAllBooksQuery, IEnumerable<BookDTO>>
    {
        private readonly IUnitOfWork unitOfWork;

        public LoadAllBooksQueryHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<BookDTO>> Handle(LoadAllBooksQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<Book> books = DatabaseInitializerBook.GetBooks();

            var result = await unitOfWork.BookRepository.CreateEntitiesAsync(books, cancellationToken).ConfigureAwait(false);

            if (result?.Any() == true)
                return result.Select(BookMapper.BookToBookDTO);
            else
                return new List<BookDTO>();
        }
    }
}
