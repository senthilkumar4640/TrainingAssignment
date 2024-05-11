
using Microsoft.AspNetCore.Mvc;
using OnlineGroceryStoreAPI.Data;

namespace OnlineGroceryStoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserDetailsController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public UserDetailsController(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }


        [HttpGet]
        public IActionResult GetUser()
        {
            return Ok(_dbContext.userList.ToList());
        }


        [HttpGet("{id}")]
        public IActionResult GetUserByID(int id)
        {
            var user = _dbContext.userList.FirstOrDefault(m => m.UserID == id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }


        [HttpPost]
        public IActionResult PostUser([FromBody] UserDetails user)
        {
            _dbContext.userList.Add(user);
            _dbContext.SaveChanges();
            return Ok();
        }


        [HttpPut("{id}")]
        public IActionResult PutUser(int id, [FromBody] UserDetails user)
        {
            var users = _dbContext.userList.FirstOrDefault(m => m.UserID == id);
            if (users == null)
            {
                return NotFound();
            }
            users.UserName = user.UserName;
            users.UserEmail = user.UserEmail;
            users.UserPassword = user.UserPassword;
            users.UserPhone = user.UserPhone;
            users.UserImage = user.UserImage;
            users.UserAddress = user.UserAddress;
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}/{amount}")]
        public IActionResult PutAmount(int id, int amount)
        {
            var index = _dbContext.userList.FirstOrDefault(m => m.UserID == id);
            if (index != null)
            {
                index.UserBalance += amount;
            }
            _dbContext.SaveChanges();
            return Ok();
        }

    }
}


