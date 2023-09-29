using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication20.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly List<USer> _users; 
        public UserController()
        {
            _users = new List<USer>();
            for(int i = 1;i<= 10;i++)
            {
                USer u = new USer()
                {
                    Id = i,
                    Name = $"JAck{i}",
                    LastName = $"Smith{i}"
                };
            _users.Add(u);
            }
        }
        [HttpGet]
        [Route("get-all")]
        public IActionResult GetAllUsers() //end point 
        {
            var data = _users;
            return Ok(data);
        }
    }
}
