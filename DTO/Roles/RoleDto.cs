namespace api.DTO.Roles;

public class RoleDto : BaseRoleDto
{
    public Guid RoleId { get; set; }
    public ICollection<PermissionDto> Permissions { get; set; }
}