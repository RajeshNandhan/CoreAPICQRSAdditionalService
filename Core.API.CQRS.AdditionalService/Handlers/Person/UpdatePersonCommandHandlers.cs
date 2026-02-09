using Core.API.AdditionalServiceLibrary;
using MediatR;

#nullable disable

namespace Core.API.CQRS.AdditionalService
{
    public class UpdatePersonCommandHandlers : IRequestHandler<UpdatePersonCommand, long>
    {
        private readonly IUnitOfWork unitOfWork;

        public UpdatePersonCommandHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<long> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            var Person = await unitOfWork.PersonRepository.GetEntityByIdAsync(request.personId, cancellationToken);

            if (Person == null)
                return 0;

            var result = await unitOfWork.PersonRepository.UpdateAsync(request.personId, request.person, cancellationToken).ConfigureAwait(false);
            
            return result;
        }
    }
}
