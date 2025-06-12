namespace api.Models.Role;

public class RolePermission : BaseModel
{
    public Guid RolePermissionId { get; set; }
    public Guid RoleId { get; set; }
    public Guid PermissionId { get; set; }
    public string Status { get; set; } = "ACTIVE";
    public bool? IsDeleted { get; set; } = false;
    public Guid CreatedBy { get; set; }
    public Guid? UpdatedBy { get; set; }
    public Guid? DeletedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public Role Role { get; set; }
    public Permission Permission { get; set; }
}