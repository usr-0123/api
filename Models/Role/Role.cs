using api.Models.ApplicationModules;
using api.Models.User;

namespace api.Models.Role;

public class Role : BaseModel
{
    public Guid RoleId { get; set; }
    public Guid ApplicationModuleId { get; set; }
    public ICollection<Permission> Permissions { get; set; }
    public ICollection<RolePermission> RolePermissions { get; set; }
    public ICollection<UserRole> UserRoles { get; set; }
    public ApplicationModule ApplicationModule { get; set; }
}