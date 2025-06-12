using System.ComponentModel.DataAnnotations;

namespace api.Models.User;

public class UserRole : BaseModel
{
    public Guid UserRoleID { get; set; }
    public string? Name { get; set; }
    public Guid RoleId { get; set; }
    public Guid UserId { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? CreatedDTM { get; set; }
    public Guid? UpdatedBy { get; set; }
    public DateTime? UpdatedDTM { get; set; }
    public bool IsDeleted { get; set; } = false;
    [Timestamp]
    public virtual byte[]? RowVersion { get; set; }
    public Role.Role? Role { get; set; }
    public User? User { get; set; }
}