using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record CreateBookCommand(BookDTO Book) : IRequest<Book>;
}