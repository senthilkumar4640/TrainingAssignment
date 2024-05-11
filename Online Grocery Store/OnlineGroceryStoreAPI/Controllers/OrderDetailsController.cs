using Microsoft.AspNetCore.Mvc;
using OnlineGroceryStoreAPI.Data;

namespace OnlineGroceryStoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderDetailsController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public OrderDetailsController(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }


        [HttpGet]
        public IActionResult Getorder()
        {
            return Ok(_dbContext.orderList.ToList());
        }


        [HttpGet("{id}")]
        public IActionResult GetorderByID(int id)
        {
            var order = _dbContext.orderList.FirstOrDefault(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }


        [HttpPost]
        public IActionResult Postorder([FromBody] OrderDetails order)
        {
            _dbContext.orderList.Add(order);
            _dbContext.SaveChanges();
            return Ok();
        }


        [HttpPut("{id}")]
        public IActionResult Putorder(int id, [FromBody] OrderDetails order)
        {
            var orders = _dbContext.orderList.FirstOrDefault(m => m.OrderID == id);
            if (orders == null)
            {
                return NotFound();
            }
          orders.BookingID = order.BookingID;
           orders.ProductName = order.ProductName;
           orders.PurchaseCount = order.PurchaseCount;
           orders.ProductTotalPrice = order.ProductTotalPrice;
        _dbContext.SaveChanges();
           return Ok();
        }

         [HttpDelete("{id}")]
        public IActionResult Deleteorder(int id)
        {
            var order = _dbContext.orderList.FirstOrDefault(m => m.OrderID == id);
            if(order == null)
            {
                return NotFound();
            }
            _dbContext.orderList.Remove(order);
            _dbContext.SaveChanges();
            //You might want to return NoContent or another appropriate response
            return Ok();
        }  

    }
}