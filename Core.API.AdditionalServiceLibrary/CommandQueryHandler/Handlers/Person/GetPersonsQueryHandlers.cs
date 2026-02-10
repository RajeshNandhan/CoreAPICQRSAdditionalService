using Core.Library.ArivuTharavuThalam;
using MediatR;

namespace Core.API.AdditionalServiceLibrary
{
    public class GetPersonsQueryHandlers : IRequestHandler<GetPersonsQuery, IEnumerable<PersonDTO>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetPersonsQueryHandlers(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<PersonDTO>> Handle(GetPersonsQuery request, CancellationToken cancellationToken)
        {
            var Persons = await unitOfWork.PersonRepository.GetEntitiesAsync(cancellationToken);
            var result = Persons.Select(PersonMapper.PersonToPersonDTO);

            if (result == null)
            {
                return Enumerable.Empty<PersonDTO>();
            }

            return result.OrderBy(Person => Person.dateCreated);
        }
    }
}
