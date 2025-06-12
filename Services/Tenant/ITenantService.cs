using api.DTO.Tenant;
using api.DTO;

namespace api.Services.Tenant
{
    public interface ITenantService
    {
        Task<Result<TenantResponseDto>> GetCurrentTenant();
    }
}