namespace api.DTO.User;

public class UserDto
{
    public Guid UserId { get; set; }
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public bool IsActive { get; set; }
    public string PasswordHash { get; set; }
    public DateTime? PasswordExpiryDate {get; set;}
    public string? ResetToken { get; set; }
    public DateTime? ResetDTMExpiry { get; set; }
    public string? ActivationToken { get; set; }
    public DateTime? ActivationDate { get; set; }
    public DateTime? UpdatedDTM { get; set; }
    public DateTime CreatedDTM { get; set; }
    public Guid? PersonId { get; set; }
    public bool IsDeleted { get; set; }
    public Guid? DeletedBy { get; set; }
    public DateTime? DeletedDTM { get; set; }

    //public System.Guid RoleId { get; set; }
    // public List<Role.RoleDto> Roles { get; set; }
    public string? Token { get; set; }
}