using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class MessagePublisherBookCommandHandler : IRequestHandler<MessagePublisherBookCommand, long>
    {
        public async Task<long> Handle(MessagePublisherBookCommand request, CancellationToken cancellationToken)
        {
            Logger.LogInformation(new string[] { "--> Not Connected to any Publish Messaging Queues", 
                request.Book.bookName,
                request.Book.bookCategory,
                request.Book.edition.ToString(),
                request.Book.price.ToString(),
                request.Book.image,
                request.messageType,
                request.messageAction
            });
            return await Task.FromResult(1L);
        }
    }
}
