namespace api.Models.ApplicationModules;

#nullable enable
public class ApplicationModule
{
    public Guid ApplicationModuleId { get; set; }
    public Guid ApplicationModuleCodeId { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Slug { get; set; }
    public DateTimeOffset? CreatedDTM { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTimeOffset? UpdatedDTM { get; set; }
    public Guid? UpdatedBy { get; set; }
    public DateTimeOffset? DeletedDTM { get; set; }
    public Guid? DeletedBy { get; set; }
    public bool IsDeleted { get; set; } = false;
    public virtual byte[]? RowVersion { get; set; }
    public List<TenantApplicationModule.TenantApplicationModule>? tenantApplicationModules { get; set; }
    public List<Role.Permission>? Permissions { get; set; }
}