using System.ComponentModel.DataAnnotations;

namespace api.Models.User
{
    public class User
    {
        public Guid UserId { get; set; }
        [Required]
        public Guid TenantId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public Guid? UserRoleID { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public Tenant.Tenant Tenant { get; set; }
        [Timestamp] public virtual byte[] RowVersion { get; set; }
    }
}