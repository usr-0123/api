using api.Models.ApplicationModules;

namespace api.Models.Role;

public class Permission : BaseModel
{
    public Guid PermissionId { get; set; }
    public required Guid ApplicationModuleId { get; set; }
    public required string Group { get; set; }
    public ICollection<Role>? Roles { get; set; }
    public ICollection<RolePermission>? RolePermissions { get; set; }
    public ApplicationModule? applicationModule { get; set; }
}