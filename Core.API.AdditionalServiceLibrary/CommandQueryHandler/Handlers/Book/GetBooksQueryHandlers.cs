using Core.API.AdditionalServiceLibrary;
using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class GetBooksQueryHandlers : IRequestHandler<GetBooksQuery, IEnumerable<Book>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetBooksQueryHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Book>> Handle(GetBooksQuery request, CancellationToken cancellationToken)
        {
            var books = await unitOfWork.BookRepository.GetEntitiesAsync(cancellationToken);

            return books.OrderBy(book => book.bookName);
        }
    }
}
