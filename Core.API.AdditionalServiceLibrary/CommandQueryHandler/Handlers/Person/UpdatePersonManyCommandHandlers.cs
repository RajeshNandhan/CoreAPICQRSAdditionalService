using Core.Library.ArivuTharavuThalam;
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
            var persons = request.persons.Select(person => PersonMapper.PersonDTOToPerson(person));
            var result = await unitOfWork.PersonRepository.UpdateManyAsync(Persons => true, persons, cancellationToken).ConfigureAwait(false);
            return result;
        }
    }
}
