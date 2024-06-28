using JobPortalAPI.Data.Interface;
using JobPortalAPI.Data.Module;
using JobPortalAPI.Data.ViewModel;

namespace JobPortalAPI.Data.Repository
{
    public class UserRepository : IUser
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddUser(UserDTO userdto)
        {
            try
            {
                User user = new User(); 
                user.Id = userdto.Id;
                user.FirstName = userdto.FirstName;
                user.LastName = userdto.LastName;
                user.Email = userdto.Email;
                user.Password = userdto.Password;
                user.FilePath = userdto.FilePath;
                user.FileName = userdto.FileName;
                user.IsDeleted = false;
                user.CreatedBy = 1;
                user.CreatedOn = DateTime.Now;
                user.UpdatedBy = 1;
                user.UpdatedOn = DateTime.Now;
                _context.Users.Add(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool AssignRole(RoleAssignDTO roleassigndto)
        {
            try
            {
                RoleAssign roleassign = new RoleAssign();
                
                roleassign.RoleId = roleassigndto.RoleId;
                roleassign.UserId = roleassigndto.UserId;

                _context.RoleAssigns.Add(roleassign);
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

        public UserDTO Login(LoginDTO logindto)
        {
            try
            {
                User userdata = _context.Users.FirstOrDefault(x => x.Email == logindto.Email && x.Password == logindto.Password);
                UserDTO userdto = new UserDTO();
                userdto.Id = userdata.Id;
                userdto.FirstName= userdata.FirstName;
                userdto.LastName= userdata.LastName;
                userdto.Email = userdata.Email;
               
                
                return userdto;

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
