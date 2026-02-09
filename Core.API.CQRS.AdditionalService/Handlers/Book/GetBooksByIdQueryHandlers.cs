using Core.API.AdditionalServiceLibrary;
using Core.Library.ArivuTharavuThalam;
using MediatR;

#nullable disable

namespace Core.API.CQRS.AdditionalService
{
    public class GetBooksByIdQueryHandlers : IRequestHandler<GetBooksByIdQuery, Book>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetBooksByIdQueryHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Book> Handle(GetBooksByIdQuery request, CancellationToken cancellationToken)
        {
            var book = await unitOfWork.BookRepository.GetEntityByIdAsync(request.Id, cancellationToken);
            return book;
        }
    }
}
