namespace api.DTO.Roles;

public class UserRolesListDto
{
    public Guid UserRoleId { get; set; }
    public Guid RoleId { get; set; }
    public string RoleName { get; set; }
}