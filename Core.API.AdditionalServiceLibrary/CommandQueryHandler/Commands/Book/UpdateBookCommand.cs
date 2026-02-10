using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public record UpdateBookCommand(string bookId, BookDTO book) : IRequest<long>;
}
