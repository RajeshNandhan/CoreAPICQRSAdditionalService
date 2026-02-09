using Core.API.AdditionalServiceLibrary;
using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class CreateBookCommandHandlers : IRequestHandler<CreateBookCommand, Book>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateBookCommandHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Book> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book
            {
                bookName = request.Book.bookName,
                bookCategory = request.Book.bookCategory,
                edition = request.Book.edition,
                price = request.Book.price,
                image = request.Book.image,
                personId = request.Book.personId
            };

            await unitOfWork.BookRepository.CreateEntityAsync(book, cancellationToken).ConfigureAwait(false);
            return book;
        }
    }
}
