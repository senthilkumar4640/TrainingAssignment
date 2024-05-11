using MetroCardManagementAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace MetroCardManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelDetailsController : ControllerBase
    {
        
        private readonly ApplicationDBContext _dbContext;

        public TravelDetailsController(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }

         //GET:api/User
        [HttpGet]
        public IActionResult GetTravel()
        {
            return Ok(_dbContext.travelList.ToList());
        }

        //GET : api/User/1
        [HttpGet("{id}")]
        public IActionResult GetTravelByID(int id)
        {
            var travel = _dbContext.travelList.FirstOrDefault(m=>m.TravelID==id);
            if(travel==null)
            {
                return NotFound();
            }
            return Ok(travel);
        }

        //Adding a new user
        //POST : api/User
        [HttpPost]
        public IActionResult PostTravel([FromBody] TravelDetails travel)
        {
            _dbContext.travelList.Add(travel);
            _dbContext.SaveChanges();
            //You might want to return CreatedAtAction or another appropriate response
            return Ok();
        }

        //Updating an existing user
        //PUT : api/User/1
        [HttpPut("{id}")]
        public IActionResult PutTravel(int id, [FromBody] TravelDetails travel)
        {
            var travels = _dbContext.travelList.FirstOrDefault(m=>m.TravelID == id);
            if(travels==null)
            {
                return NotFound();
            }
            travels.FromLocation = travel.FromLocation;
            travels.ToLocation = travel.ToLocation;
            travels.TravelDate = travel.TravelDate;
            travels.TravelFair = travel.TravelFair;
            _dbContext.SaveChanges();
            //You might want to return NoContent or another appropriate response
            return Ok();
            
        }


        //Deleting an existing user
        //DELETE: api/User/1
        [HttpDelete("{id}")]
        public IActionResult DeleteTravel(int id)
        {
            var data = _dbContext.travelList.FirstOrDefault(m => m.TravelID == id);
            if(data == null)
            {
                return NotFound();
            }
            _dbContext.travelList.Remove(data);
            _dbContext.SaveChanges();
            //You might want to return NoContent or another appropriate response
            return Ok();
        }  
    }
}