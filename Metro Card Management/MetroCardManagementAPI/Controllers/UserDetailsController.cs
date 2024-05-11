using MetroCardManagementAPI.Data;
using Microsoft.AspNetCore.Mvc;


namespace MetroCardManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public UserDetailsController(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }

         //GET:api/User
        [HttpGet]
        public IActionResult GetUser()
        {
            return Ok(_dbContext.userList.ToList());
        }

        //GET : api/User/1
        [HttpGet("{id}")]
        public IActionResult GetUserByID(int id)
        {
            var user = _dbContext.userList.FirstOrDefault(m=>m.CardID==id);
            if(user==null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        //Adding a new user
        //POST : api/User
        [HttpPost]
        public IActionResult PostData([FromBody] UserDetails user)
        {
            _dbContext.userList.Add(user);
            _dbContext.SaveChanges();
            //You might want to return CreatedAtAction or another appropriate response
            return Ok();
        }

        //Updating an existing user
        //PUT : api/User/1
        [HttpPut("{id}")]
        public IActionResult PutData(int id, [FromBody] UserDetails user)
        {
            var users = _dbContext.userList.FirstOrDefault(m=>m.CardID == id);
            if(users==null)
            {
                return NotFound();
            }
            users.UserName = user.UserName;
            users.UserPhoneNumber = user.UserPhoneNumber;
            users.UserPassword = user.UserPassword;
            users.Balance = user.Balance;
            _dbContext.SaveChanges();
            //You might want to return NoContent or another appropriate response
            return Ok();
        }

        [HttpPut("{id}/{amount}")]
        public IActionResult PutAmount(int id,int amount)
        {
            var index = _dbContext.userList.FirstOrDefault(m=>m.CardID == id);
            if(index!=null)
            {
                index.Balance += amount;
            }
            //You might want to return NoContent or another appropriate response
            _dbContext.SaveChanges();
            return Ok();
        }

        //Deleting an existing user
        //DELETE: api/User/1
        [HttpDelete("{id}")]
        public IActionResult DeleteData(int id)
        {
            var data = _dbContext.userList.FirstOrDefault(m => m.CardID == id);
            if(data == null)
            {
                return NotFound();
            }
            _dbContext.userList.Remove(data);
            _dbContext.SaveChanges();
            //You might want to return NoContent or another appropriate response
            return Ok();
        }  
    }
    }
