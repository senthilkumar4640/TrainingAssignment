using Microsoft.AspNetCore.Mvc;
using OnlineGroceryStoreAPI.Data;

namespace OnlineGroceryStoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingDetailsController : ControllerBase
    {
         private readonly ApplicationDBContext _dbContext;
        public BookingDetailsController(ApplicationDBContext applicationDbContext){
        _dbContext=applicationDbContext;
        }
        
        [HttpGet]
        public IActionResult GetBookings(){
            return Ok(_dbContext.bookingList);
        }

        [HttpPost]
        public IActionResult AddBookings([FromBody] BookingDetails booking)
        {
            _dbContext.bookingList.Add(booking);
            _dbContext.SaveChanges();
            return Ok(booking);
        } 
    }
}