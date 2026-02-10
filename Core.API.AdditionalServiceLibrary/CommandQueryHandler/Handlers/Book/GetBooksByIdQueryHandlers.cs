using Core.Library.ArivuTharavuThalam;
using MediatR;

#nullable disable

namespace Core.API.AdditionalServiceLibrary
{
    public class GetBooksByIdQueryHandlers : IRequestHandler<GetBooksByIdQuery, BookDTO>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetBooksByIdQueryHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<BookDTO> Handle(GetBooksByIdQuery request, CancellationToken cancellationToken)
        {
            var book = await unitOfWork.BookRepository.GetEntityByIdAsync(request.Id, cancellationToken);
            return BookMapper.BookToBookDTO(book);
        }
    }
}
