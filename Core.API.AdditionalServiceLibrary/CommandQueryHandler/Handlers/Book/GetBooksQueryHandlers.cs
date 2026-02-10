using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class GetBooksQueryHandlers : IRequestHandler<GetBooksQuery, IEnumerable<BookDTO>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetBooksQueryHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<BookDTO>> Handle(GetBooksQuery request, CancellationToken cancellationToken)
        {
            var books = await unitOfWork.BookRepository.GetEntitiesAsync(cancellationToken);
            var bookDTOs = books.Select(BookMapper.BookToBookDTO);

            if(bookDTOs == null)
            {
                return Enumerable.Empty<BookDTO>();
            }

            return bookDTOs.OrderBy(book => book.bookName);
        }
    }
}
