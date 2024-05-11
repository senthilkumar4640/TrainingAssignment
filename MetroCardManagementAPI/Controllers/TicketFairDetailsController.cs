using MetroCardManagementAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace MetroCardManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  
    public class TicketFairDetailsController: ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public TicketFairDetailsController (ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }

         //GET:api/User
        [HttpGet]
        public IActionResult GetTicket()
        {
            return Ok(_dbContext.ticketFairList.ToList());
        }

        //GET : api/User/1
        [HttpGet("{id}")]
        public IActionResult GetTicketByID(int id)
        {
            var ticket = _dbContext.ticketFairList.FirstOrDefault(m=>m.TicketID==id);
            if(ticket==null)
            {
                return NotFound();
            }
            return Ok(ticket);
        }

        //Adding a new user
        //POST : api/User
        [HttpPost]
        public IActionResult PostTicket([FromBody] TicketFairDetails ticket)
        {
            _dbContext.ticketFairList.Add(ticket);
            _dbContext.SaveChanges();
            //You might want to return CreatedAtAction or another appropriate response
            return Ok();
        }

        //Updating an existing user
        //PUT : api/User/1
        [HttpPut("{id}")]
        public IActionResult PutTicket(int id, [FromBody] TicketFairDetails ticket)
        {
            var tickets = _dbContext.ticketFairList.FirstOrDefault(m=>m.TicketID == id);
            if(tickets==null)
            {
                return NotFound();
            }
           tickets.FromLocation = ticket.FromLocation;
           tickets.ToLocation = ticket.ToLocation;
           tickets.TicketFair = ticket.TicketFair;
           _dbContext.SaveChanges();
          
            //You might want to return NoContent or another appropriate response
            return Ok();
            
        }


        //Deleting an existing user
        //DELETE: api/User/1
        [HttpDelete("{id}")]
        public IActionResult DeleteTicket(int id)
        {
            var data = _dbContext.ticketFairList.FirstOrDefault(m => m.TicketID == id);
            if(data == null)
            {
                return NotFound();
            }
            _dbContext.ticketFairList.Remove(data);
            _dbContext.SaveChanges();
            //You might want to return NoContent or another appropriate response
            return Ok();
        }  
    }
    }
