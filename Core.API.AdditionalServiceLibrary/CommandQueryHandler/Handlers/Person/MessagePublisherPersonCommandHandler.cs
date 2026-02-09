using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class MessagePublisherPersonCommandHandler : IRequestHandler<MessagePublisherPersonCommand, long>
    {
        public async Task<long> Handle(MessagePublisherPersonCommand request, CancellationToken cancellationToken)
        {
            Logger.LogInformation(new string[] { "--> Not Connected to any Publish Messaging Queues", 
                request.Person.category,
                request.Person.lastName,
                request.Person.isPlayCricket.ToString(),
                request.Person.firstName.ToString(),
                request.Person.rank.ToString(),
                request.Person.isPlayCricket.ToString(),
                request.messageType,
                request.messageAction
            });
            return await Task.FromResult(1L);
        }
    }
}
