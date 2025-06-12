using api.Models.Role;

namespace api.DTO.Roles;

public class PermissionDto
{
    public System.Guid PermissionId { get; set; }
    public string Group { get; set; }
    public ICollection<Models.Role.Role> Roles { get; set; }
    public ICollection<RolePermission> RolePermissions { get; set; }
}