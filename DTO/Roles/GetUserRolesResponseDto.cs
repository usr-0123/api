namespace api.DTO.Roles;

public class GetUserRolesResponseDto
{
    public Guid UserId { get; set; }
    public string UserName { get; set; }
    public ICollection<UserRolesListDto> Roles { get; set; }
}