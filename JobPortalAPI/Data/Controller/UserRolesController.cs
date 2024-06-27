using JobPortalAPI.Data.Interface;
using JobPortalAPI.Data.Module;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalAPI.Data.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRolesController : ControllerBase
    {
        private readonly IUserRole _userrole;

        public UserRolesController(IUserRole userrole)
        {
            _userrole = userrole;
        }

        [Route("GetAllUserRoles")]

        [HttpGet]

        public IActionResult GetAllUserRoles()
        {
            return Ok(_userrole.GetAllUserRoles());
        }

        [Route("GetUserRoleById")]

        [HttpGet]

        public IActionResult GetUserRoleById(int Id)
        {
            return Ok(_userrole.GetUserRoleById(Id));
        }

        [Route("AddUserRole")]

        [HttpPost]

        public IActionResult AddUserRole(UserRole userrole)
        {
            return Ok(_userrole.AddUserRole(userrole));
        }

        [Route("UpdateUserRole")]

        [HttpPut]

        public IActionResult UpdateUserRole(UserRole userrole)
        {
            return Ok(_userrole.UpdateUserRole(userrole));
        }

        [Route("DeleteUserRole")]

        [HttpDelete]

        public IActionResult DeleteUserRole(int Id)
        {
            return Ok(_userrole?.DeleteUserRole(Id));
        }


    }
}
