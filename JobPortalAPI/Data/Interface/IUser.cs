using JobPortalAPI.Data.Module;

namespace JobPortalAPI.Data.Interface
{
    public interface IUser
    {
        bool AddUser(User users);

        bool UpdateUser(User users);

        bool DeleteUser(int Id);

        List<User> GetAllUsers();

        User GetUsersById(int Id);

    }
}
