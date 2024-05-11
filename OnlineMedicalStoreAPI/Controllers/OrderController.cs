using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineMedicalStoreAPI.Data;

namespace OnlineMedicalStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
       private readonly ApplicationDBContext _dbContext;
        public OrderController(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }
        //GET:api/Order
        [HttpGet]
        public IActionResult GetOrder()
        {
            return Ok(_dbContext.orderList.ToList());
        }

        //GET : api/Order/1
        [HttpGet("{id}")]
        public IActionResult GetOrderByID(int id)
        {
            var order = _dbContext.orderList.FirstOrDefault(m=>m.OrderID==id);
            if(order==null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        //Adding a new order
        //POST : api/Order
        [HttpPost]
        public IActionResult PostOrder([FromBody] Order order)
        {
            _dbContext.orderList.Add(order);
            //You might want to return CreatedAtAction or another appropriate response
            _dbContext.SaveChanges();
            return Ok();
        }

        //Updating an existing order
        //PUT : api/Contacts/1
        [HttpPut("{id}")]
        public IActionResult PutOrder(int id, [FromBody] Order order)
        {
            var orders = _dbContext.orderList.FirstOrDefault(m=>m.OrderID == id);
            if(orders==null)
            {
                return NotFound();
            }
            orders.UserID = order.UserID;
            orders.MedicineID = order.MedicineID;
            orders.MedicineName = order.MedicineName;
            orders.MedicineCount = order.MedicineCount;
            orders.OrderStatus = order.OrderStatus;
            _dbContext.SaveChanges();
            //You might want to return NoContent or another appropriate response
            return Ok();
            
        }

        //Deleting an existing order
        //DELETE: api/Order/1
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
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