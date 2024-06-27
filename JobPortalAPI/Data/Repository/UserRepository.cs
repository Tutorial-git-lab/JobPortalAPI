using JobPortalAPI.Data.Interface;
using JobPortalAPI.Data.Module;

namespace JobPortalAPI.Data.Repository
{
    public class UserRepository : IUser
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddUser(User users)
        {
            try
            {
                _context.Users.Add(users);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteUser(int Id)
        {
            try
            {
                var user = _context.Users.Find(Id);
                _context.Users.Remove(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<User> GetAllUsers()
        {
            try
            {
                return _context.Users.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public User GetUsersById(int Id)
        {
            try
            {
                return _context.Users.Find(Id);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public bool UpdateUser(User users)
        {
            try
            {
                _context.Users.Update(users);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return true;
            }
        }
    }
}
