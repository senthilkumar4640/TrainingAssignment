using OnlineLibraryManagementAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace OnlineLibraryManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class  BorrowDetailsController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public BorrowDetailsController(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }

         //GET:api/BorrowDetails
        [HttpGet]
        public IActionResult GetBorrow()
        {
            return Ok(_dbContext.borrowList.ToList());
        }

        //GET : api/BorrowDetails/1
        [HttpGet("{id}")]
        public IActionResult GetBorrowByID(int id)
        {
            var borrow = _dbContext.borrowList.FirstOrDefault(m=>m.BorrowID==id);
            if(borrow==null)
            {
                return NotFound();
            }
            return Ok(borrow);
        }

        //Adding a new Borrow
        //POST : api/BorrowDetails
        [HttpPost]
        public IActionResult PostBorrow([FromBody] BorrowDetails borrow)
        {
            _dbContext.borrowList.Add(borrow);
            _dbContext.SaveChanges();
            //You might want to return CreatedAtAction or another appropriate response
            return Ok();
        }

        //Updating an existing Borrow
        //PUT : api/BorrowDetails/1
        [HttpPut("{id}")]
        public IActionResult PutBorrow(int id, [FromBody] BorrowDetails borrow)
        {
            var borrows = _dbContext.borrowList.FirstOrDefault(m=>m.BorrowID == id);
            if(borrows==null)
            {
                return NotFound();
            }
           borrows.BookID = borrow.BookID;
           borrows.UserID = borrow.UserID;
           borrows.BorrowedDate = borrow.BorrowedDate;
           borrows.BorrowBookCount = borrow.BorrowBookCount;
           borrows.Status = borrow.Status;
           borrows.PaidFineAmount = borrow.PaidFineAmount;
           _dbContext.SaveChanges();
            //You might want to return NoContent or another appropriate response
            return Ok();
        }

        //Deleting an existing Borrow
        //DELETE: api/BorrowDetails/1
        [HttpDelete("{id}")]
        public IActionResult DeleteData(int id)
        {
            var data = _dbContext.borrowList.FirstOrDefault(m => m.BorrowID == id);
            if(data == null)
            {
                return NotFound();
            }
            _dbContext.borrowList.Remove(data);
            _dbContext.SaveChanges();
            //You might want to return NoContent or another appropriate response
            return Ok();
    }
}
}