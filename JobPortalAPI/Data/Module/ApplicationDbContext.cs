using Microsoft.EntityFrameworkCore;

namespace JobPortalAPI.Data.Module
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UsersRoles { get; set; }

        public DbSet<RoleAssign> RoleAssigns { get; set; }
        
    }

}
