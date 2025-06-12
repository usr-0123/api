using api.Models.ApplicationModules;

namespace api.Models.TenantApplicationModule;

public class TenantApplicationModule
{
    public Guid TenantApplicationModuleId { get; set; }
    public Guid TenantId { get; set; }
    public Guid ApplicationModuleId { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? UpdatedDTM { get; set; }
    public Guid? UpdatedBy { get; set; }
    public DateTime? DeletedDTM { get; set; }
    public Guid? DeletedBy { get; set; }
    public bool IsDeleted { get; set; }
    public virtual byte[]? RowVersion { get; set; }
    public Tenant.Tenant Tenant { get; set; }
    public ApplicationModule ApplicationModule { get; set; }
}