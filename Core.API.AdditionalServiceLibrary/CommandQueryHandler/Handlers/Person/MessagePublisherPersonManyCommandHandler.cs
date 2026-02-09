using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class MessagePublisherPersonManyCommandHandler : IRequestHandler<MessagePublisherPersonManyCommand, long>
    {
        public async Task<long> Handle(MessagePublisherPersonManyCommand request, CancellationToken cancellationToken)
        {
            Logger.LogInformation([ "--> Not Connected to any Publish Messaging Queues",
                request.messageType,
                request.messageAction
            ]);

            foreach (var item in request.Persons)
            {
                Logger.LogInformation(new string[] {
                    item.isPlayCricket.ToString(),
                    item.firstName.ToString(),
                    item.rank.ToString(),
                    item.isPlayCricket.ToString(),
                    item.category,
                    item.lastName,
                    request.messageType,
                    request.messageAction
                });
            }

            return await Task.FromResult((long)request.Persons.Count());
        }
    }
}
