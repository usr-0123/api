namespace api.Helpers.ActivityLog
{
    public class AuthenticatedUser
    {
        public Guid UserId { get; set; }
        public Guid? PersonId { get; set; }
        public Guid TenantId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public Guid? RoleId { get; set; }
        // public Role? Role { get; set; }
        public List<string>? Roles { get; set; }
        public IEnumerable<long>? AllowedLocations { get; set; }
    }
    
    public class AuthenticationHelpers
    {

    }
}