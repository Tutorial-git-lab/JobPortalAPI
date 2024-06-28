using JobPortalAPI.Data.Interface;
using JobPortalAPI.Data.Module;
using JobPortalAPI.Data.ViewModel;
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

        [Route("Login")]

        [HttpPost]
        public IActionResult Login(LoginDTO logindto)
        {
            return Ok();
        }

        

        [Route("AssignRole")]

        [HttpPost]
        public IActionResult AssignRole(RoleAssignDTO roleassigndto)
        {
            return Ok();
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

        public IActionResult AddUser(UserDTO userdto)
        {
            return Ok(_user.AddUser(userdto));
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
