using Core.Library.ArivuTharavuThalam;
using MediatR;

#nullable disable

namespace Core.API.AdditionalServiceLibrary
{
    public class GetPersonsByIdQueryHandlers : IRequestHandler<GetPersonByIdQuery, PersonDTO>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetPersonsByIdQueryHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<PersonDTO> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            var Person = await unitOfWork.PersonRepository.GetEntityByIdAsync(request.Id, cancellationToken);
            return PersonMapper.PersonToPersonDTO(Person);
        }
    }
}
