using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class CreateBookManyCommandHandlers : IRequestHandler<CreateBookManyCommand, IEnumerable<BookDTO>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMediator mediator;

        public CreateBookManyCommandHandlers(IUnitOfWork unitOfWork, IMediator mediator)
        {
            this.unitOfWork = unitOfWork;
            this.mediator = mediator;
        }

        public async Task<IEnumerable<BookDTO>> Handle(CreateBookManyCommand request, CancellationToken cancellationToken)
        {
            var books = request.Books.Select(book => BookMapper.BookCreateDTOToBook(book));

            var results = await unitOfWork.BookRepository.CreateEntitiesAsync(books, cancellationToken).ConfigureAwait(false);

            await mediator.Send(new MessagePublisherBookManyCommand(results, MessageTypeConstant.BookType, MessageActionConstant.Create, cancellationToken), default).ConfigureAwait(false);

            return results.Select(BookMapper.BookToBookDTO);
        }
    }
}
