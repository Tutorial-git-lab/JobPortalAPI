using JobPortalAPI.Data.Module;
using JobPortalAPI.Data.ViewModel;

namespace JobPortalAPI.Data.Interface
{
    public interface IUser
    {
        
        bool AddUser(UserDTO userdto);

        bool UpdateUser(User users);

        bool DeleteUser(int Id);

        List<User> GetAllUsers();

        User GetUsersById(int Id);

        bool AssignRole(RoleAssignDTO roleassigndto);

        UserDTO Login(LoginDTO logindto);

    }
}
