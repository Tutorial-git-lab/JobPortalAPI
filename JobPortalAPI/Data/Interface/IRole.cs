using JobPortalAPI.Data.Module;

namespace JobPortalAPI.Data.Interface
{
    public interface IRole
    {
        bool AddRole(Role role);

        bool UpdateRole(Role role);

        bool DeleteRole(int Id);

        List<Role> GetAllRoles();

        Role GetRoleById(int Id);
    }
}
