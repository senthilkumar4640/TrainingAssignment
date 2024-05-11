using OnlineLibraryManagementAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace OnlineLibraryManagementAPI.Controllers
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

         //GET:api/UserDetails
        [HttpGet]
        public IActionResult GetUser()
        {
            return Ok(_dbContext.userList.ToList());
        }

        //GET : api/UserDetails/1
        [HttpGet("{id}")]
        public IActionResult GetUserByID(int id)
        {
            var user = _dbContext.userList.FirstOrDefault(m=>m.UserID==id);
            if(user==null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        //Adding a new user
        //POST : api/UserDetails
        [HttpPost]
        public IActionResult PostData([FromBody] UserDetails user)
        {
            _dbContext.userList.Add(user);
            _dbContext.SaveChanges();
            //You might want to return CreatedAtAction or another appropriate response
            return Ok();
        }

        //Updating an existing user
        //PUT : api/UserDetails/1
        [HttpPut("{id}")]
        public IActionResult PutData(int id, [FromBody] UserDetails user)
        {
            var users = _dbContext.userList.FirstOrDefault(m=>m.UserID == id);
            if(users==null)
            {
                return NotFound();
            }
            users.UserName = user.UserName;
            users.Gender = user.Gender;
            users.Department = user.Department;
            users.MobileNumber = user.MobileNumber;
            users.MailID = user.MailID;
            users.WalletBalance = user.WalletBalance;
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
                index.WalletBalance += amount;
            }
            //You might want to return NoContent or another appropriate response
            _dbContext.SaveChanges();
            return Ok();
        }

        //Deleting an existing user
        //DELETE: api/UserDetails/1
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