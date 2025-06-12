using System.ComponentModel.DataAnnotations;

namespace api.Models.User
{
    public class User
    {
        public Guid UserId { get; set; }
        [Required]
        public Guid TenantId { get; set; }
    }
}