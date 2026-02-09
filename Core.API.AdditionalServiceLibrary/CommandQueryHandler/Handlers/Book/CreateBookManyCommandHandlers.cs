using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class CreateBookManyCommandHandlers : IRequestHandler<CreateBookManyCommand, IEnumerable<Book>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMediator mediator;

        public CreateBookManyCommandHandlers(IUnitOfWork unitOfWork, IMediator mediator)
        {
            this.unitOfWork = unitOfWork;
            this.mediator = mediator;
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

            await mediator.Send(new MessagePublisherBookManyCommand(request.Books, MessageTypeConstant.BookType, MessageActionConstant.Create, cancellationToken), default).ConfigureAwait(false);

            return books;
        }
    }
}
