using Core.API.AdditionalServiceLibrary;
using Core.Library.ArivuTharavuThalam;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Core.API.CQRS.AdditionalService.Controllers
{
    /// <summary>
    /// PersonController
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator mediator = mediator;

        /// <summary>
        /// Get All Person(s)
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<PersonDTO>> Get()
        {
            return await mediator.Send(new GetPersonsQuery(), default).ConfigureAwait(false);
        }

        /// <summary>
        /// Get Single Person by Id
        /// Input - Id
        /// </summary>
        [HttpGet("{personId}")]
        public async Task<PersonDTO> Get(string personId)
        {
            var result = await mediator.Send(new GetPersonByIdQuery(personId), default).ConfigureAwait(false);
            return result;
        }

        /// <summary>
        /// Update Single Person by Id
        /// Input - Person, Id
        /// </summary>
        [HttpPut("{personId}")]
        public async Task<long> Put(string personId, PersonDTO person)
        {
            var result = await mediator.Send(new UpdatePersonCommand(personId, person), default).ConfigureAwait(false);
            return result;
        }

        /// <summary>
        /// Update Multiple Person
        /// Input - Person(s)
        /// TODO Update based on searchValue 
        /// </summary>
        [HttpPut("Many")]
        public async Task<long> PutMany(string searchValue, IEnumerable<PersonDTO> persons)
        {
            var result = await mediator.Send(new UpdatePersonManyCommand(searchValue, persons), default).ConfigureAwait(false);
            return result;
        }

        /// <summary>
        /// Create Single Person
        /// Input - Person
        /// </summary>
        [HttpPost]
        public async Task<PersonDTO> Post(PersonCreateDTO person)
        {
            var personresult = await mediator.Send(new CreatePersonCommand(person), default).ConfigureAwait(false);
            return personresult;
        }

        /// <summary>
        /// Create Multiple Person(s)
        /// Input - Person(s)
        /// </summary>
        [HttpPost("Many")]
        public async Task<IEnumerable<PersonDTO>> PostMany(IEnumerable<PersonCreateDTO> persons)
        {
            var personresult = await mediator.Send(new CreatePersonManyCommand(persons), default).ConfigureAwait(false);
            return personresult;
        }

        /// <summary>
        /// Delete Single Person
        /// Input - Id
        /// </summary>
        [HttpDelete("{personId}")]
        public async Task<long> Delete(string personId)
        {
            var result = await mediator.Send(new DeletePersonCommand(personId), default).ConfigureAwait(false);
            return result;
        }

        /// <summary>
        /// Delete Multiple Person(s)
        /// </summary>
        [HttpDelete("Many")]
        public async Task<long> DeleteMany()
        {
            var result = await mediator.Send(new DeletePersonManyCommand(), default).ConfigureAwait(false);
            return result;
        }

        /// <summary>
        /// Load and Create Multiple Person(s), Input - Static Collection
        /// </summary>
        [HttpGet("LoadAllPersonForNewDatabase")]
        public async Task<IEnumerable<PersonDTO>> LoadAllPersonForNewDatabase()
        {
            var result = await mediator.Send(new LoadAllPerssonsQuery(), default).ConfigureAwait(false);
            return result;
        }
    }
}
