using JobPortalAPI.Data.Interface;
using JobPortalAPI.Data.Module;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalAPI.Data.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _user;

        public UserController(IUser user)
        {
            _user = user;
        }

        [Route("GetAllUsers")]

        [HttpGet]

        public IActionResult GetAllUsers()
        {
            return Ok(_user.GetAllUsers());
        }

        [Route("GetUserById")]

        [HttpGet]

        public IActionResult GetUserById(int Id)
        {
            return Ok(_user.GetUsersById(Id));
        }

        [Route("AddUser")]

        [HttpPost]

        public IActionResult AddUser(User user)
        {
            return Ok(_user.AddUser(user));
        }

        [Route("UpdateUser")]

        [HttpPut]

        public IActionResult UpdateUser(User user)
        {
            return Ok(_user.UpdateUser(user));
        }

        [Route("DeleteUser")]

        [HttpDelete]

        public IActionResult DeleteUser(int Id)
        {
            return Ok(_user.DeleteUser(Id));

        }
    }
}
