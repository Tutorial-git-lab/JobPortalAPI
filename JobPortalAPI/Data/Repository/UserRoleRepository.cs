using JobPortalAPI.Data.Interface;
using JobPortalAPI.Data.Module;

namespace JobPortalAPI.Data.Repository
{
    public class UserRoleRepository : IUserRole
    {
        private readonly ApplicationDbContext _context;

        public UserRoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddUserRole(UserRole userrole)
        {
            try
            {
                _context.UsersRoles.Add(userrole);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteUserRole(int Id)
        {
            try
            {
                var userrole = _context.UsersRoles.Find(Id);
                _context.UsersRoles.Remove(userrole);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<UserRole> GetAllUserRoles()
        {
            try
            {
                return _context.UsersRoles.ToList();

            }
            catch (Exception)
            {

                return null;
            }
        }

        public UserRole GetUserRoleById(int Id)
        {
            try
            {
                return _context.UsersRoles.Find(Id);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public bool UpdateUserRole(UserRole userrole)
        {
            try
            {
                _context.UsersRoles.Update(userrole);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
