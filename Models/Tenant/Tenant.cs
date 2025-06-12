using System.ComponentModel.DataAnnotations;

namespace api.Models.Tenant;

public class Tenant
{
    [Key]
    public Guid TenantId { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public DateTime CreatedDTM { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTime? UpdatedDTM { get; set; }
    public Guid? UpdatedBy { get; set; }
    public bool IsDeleted { get; set; }
    public Guid? DeletedBy { get; set; }
    public DateTime? DeletedDTM { get; set; }
    [Timestamp]
    public virtual byte[]? RowVersion { get; set; }
    public List<TenantApplicationModule.TenantApplicationModule>? tenantApplicationModules { get; set; }
}