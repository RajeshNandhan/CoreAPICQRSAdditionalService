using Core.API.AdditionalServiceLibrary;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class UpdatePersonManyCommandHandlers : IRequestHandler<UpdatePersonManyCommand, long>
    {
        private readonly IUnitOfWork unitOfWork;

        public UpdatePersonManyCommandHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<long> Handle(UpdatePersonManyCommand request, CancellationToken cancellationToken)
        {
            var result = await unitOfWork.PersonRepository.UpdateManyAsync(Persons => true, request.persons, cancellationToken).ConfigureAwait(false);
            return result;
        }
    }
}
