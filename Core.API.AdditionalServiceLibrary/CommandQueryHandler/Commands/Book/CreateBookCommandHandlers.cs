using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class CreateBookCommandHandlers : IRequestHandler<CreateBookCommand, BookDTO>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMediator mediator;

        public CreateBookCommandHandlers(IUnitOfWork unitOfWork, IMediator mediator)
        {
            this.unitOfWork = unitOfWork;
            this.mediator = mediator;
        }

        public async Task<BookDTO> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = BookMapper.BookCreateDTOToBook(request.Book);

            var result = await unitOfWork.BookRepository.CreateEntityAsync(book, cancellationToken).ConfigureAwait(false);

            await mediator.Publish(new BookCreatedEvent(result, MessageTypeConstant.BookType, MessageActionConstant.Create, cancellationToken), default).ConfigureAwait(false);

            return BookMapper.BookToBookDTO(result);
        }
    }
}
