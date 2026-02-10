using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class MessagePublisherBookManyCommandHandler : IRequestHandler<MessagePublisherBookManyCommand, long>
    {
        public async Task<long> Handle(MessagePublisherBookManyCommand request, CancellationToken cancellationToken)
        {
            Logger.LogInformation([ "--> Not Connected to any Publish Messaging Queues",
                request.messageType,
                request.messageAction
            ]);

            foreach (var item in request.Books)
            {
                Logger.LogInformation(new string[] {
                    item.bookName,
                    item.bookCategory,
                    item.edition.ToString(),
                    item.price.ToString(),
                    item.image,
                    request.messageType,
                    request.messageAction
                });
            }

            return await Task.FromResult((long)request.Books.Count());
        }
    }
}
