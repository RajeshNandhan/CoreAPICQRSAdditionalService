using Core.Library.ArivuTharavuThalam;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Core.API.CQRS.AdditionalService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator mediator = mediator;

        /// <summary>
        /// Get All Book(s)
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<Book>> Get()
        {
            return await mediator.Send(new GetBooksQuery(), default).ConfigureAwait(false);
        }

        /// <summary>
        /// Get Single Book by Id
        /// Input - Id
        /// </summary>
        [HttpGet("{bookId}")]
        public async Task<Book> Get(string bookId)
        {
            var result = await mediator.Send(new GetBooksByIdQuery(bookId), default).ConfigureAwait(false);
            return result;
        }

        /// <summary>
        /// Update Single Book by Id
        /// Input - Book, Id
        /// </summary>
        [HttpPut("{bookId}")]
        public async Task<long> Put(string bookId, Book book)
        {
            var result = await mediator.Send(new UpdateBookCommand(bookId, book), default).ConfigureAwait(false);
            return result;
        }

        /// <summary>
        /// Update Multiple Book
        /// Input - Book(s)
        /// TODO Update based on searchValue 
        /// </summary>
        [HttpPut("Many")]
        public async Task<long> PutMany(string searchValue, IEnumerable<Book> books)
        {
            var result = await mediator.Send(new UpdateBookManyCommand(searchValue, books), default).ConfigureAwait(false);
            return result;
        }

        /// <summary>
        /// Create Single Book
        /// Input - Book
        /// </summary>
        [HttpPost]
        public async Task<Book> Post(BookDTO book)
        {
            var bookresult = await mediator.Send(new CreateBookCommand(book), default).ConfigureAwait(false);
            return bookresult;
        }

        /// <summary>
        /// Create Multiple Book(s)
        /// Input - Book(s)
        /// </summary>
        [HttpPost("Many")]
        public async Task<IEnumerable<Book>> PostMany(IEnumerable<BookDTO> books)
        {
            var bookresult = await mediator.Send(new CreateBookManyCommand(books), default).ConfigureAwait(false);
            return bookresult;
        }

        /// <summary>
        /// Delete Single Book
        /// Input - Id
        /// </summary>
        [HttpDelete("{bookId}")]
        public async Task<long> Delete(string bookId)
        {
            var result = await mediator.Send(new DeleteBookCommand(bookId), default).ConfigureAwait(false);
            return result;
        }

        /// <summary>
        /// Delete Multiple Book(s)
        /// </summary>
        [HttpDelete("Many")]
        public async Task<long> DeleteAll()
        {
            var result = await mediator.Send(new DeleteBookManyCommand(), default).ConfigureAwait(false);
            return result;
        }

        /// <summary>
        /// Load and Create Multiple Book(s), Input - Static Collection
        /// </summary>
        [HttpGet("LoadAllBookForNewDatabase")]
        public async Task<IEnumerable<Book>> LoadAllBookForNewDatabase()
        {
            var result = await mediator.Send(new LoadAllBooksQuery(), default).ConfigureAwait(false);
            return result;
        }
    }
}
