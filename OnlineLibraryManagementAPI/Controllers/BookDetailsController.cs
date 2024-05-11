using OnlineLibraryManagementAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace OnlineLibraryManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookDetailsController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public BookDetailsController(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }

         //GET:api/BookDetails
        [HttpGet]
        public IActionResult GetBook()
        {
            return Ok(_dbContext.bookList.ToList());
        }

        //GET : api/BookDetails/1
        [HttpGet("{id}")]
        public IActionResult GetBookByID(int id)
        {
            var book = _dbContext.bookList.FirstOrDefault(m=>m.BookID==id);
            if(book==null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        //Adding a new book
        //POST : api/Bookdetails
        [HttpPost]
        public IActionResult PostBook([FromBody] BookDetails book)
        {
            _dbContext.bookList.Add(book);
            _dbContext.SaveChanges();
            //You might want to return CreatedAtAction or another appropriate response
            return Ok();
        }

        //Updating an existing book
        //PUT : api/BookDetails/1
        [HttpPut("{id}")]
        public IActionResult PutBook(int id, [FromBody] BookDetails book)
        {
            var books = _dbContext.bookList.FirstOrDefault(m=>m.BookID == id);
            if(books==null)
            {
                return NotFound();
            }
            books.BookName = book.BookName;
            books.AuthorName = book.AuthorName;
            books.BookCount = book.BookCount;
            _dbContext.SaveChanges();
            //You might want to return NoContent or another appropriate response
            return Ok();
        }

        //Deleting an existing book
        //DELETE: api/BookDetails/1
        [HttpDelete("{id}")]
        public IActionResult DeleteData(int id)
        {
            var data = _dbContext.bookList.FirstOrDefault(m => m.BookID == id);
            if(data == null)
            {
                return NotFound();
            }
            _dbContext.bookList.Remove(data);
            _dbContext.SaveChanges();
            //You might want to return NoContent or another appropriate response
            return Ok();
    }
}
}