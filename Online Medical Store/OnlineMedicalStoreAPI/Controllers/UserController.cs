using Microsoft.AspNetCore.Mvc;
using OnlineMedicalStoreAPI.Data;

namespace OnlineMedicalStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        public UserController(ApplicationDBContext applicationDBContext)
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
            var medicine = _dbContext.userList.FirstOrDefault(m=>m.UserID==id);
            if(medicine==null)
            {
                return NotFound();
            }
            return Ok(medicine);
        }

        //Adding a new user
        //POST : api/User
        [HttpPost]
        public IActionResult PostData([FromBody] User user)
        {
            _dbContext.userList.Add(user);
            _dbContext.SaveChanges();
            //You might want to return CreatedAtAction or another appropriate response
            return Ok();
        }

        //Updating an existing user
        //PUT : api/User/1
        [HttpPut("{id}")]
        public IActionResult PutData(int id, [FromBody] User user)
        {
            var users = _dbContext.userList.FirstOrDefault(m=>m.UserID == id);
            if(users==null)
            {
                return NotFound();
            }
            users.UserName = user.UserName;
            users.UserEmail = user.UserEmail;
            users.UserPassword = user.UserPassword;
            users.UserBalance = user.UserBalance;
            _dbContext.SaveChanges();
            //You might want to return NoContent or another appropriate response
            return Ok();
            
        }

         [HttpPut("{id}/{amount}")]
        public IActionResult PutAmount(int id,int amount)
        {
            var index = _dbContext.userList.FirstOrDefault(m=>m.UserID == id);
            if(index!=null)
            {
                index.UserBalance += amount;
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
            var data = _dbContext.userList.FirstOrDefault(m => m.UserID == id);
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