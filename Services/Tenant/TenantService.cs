using System.Net;
using api.Data;
using api.DTO;
using api.DTO.Tenant;

namespace api.Services.Tenant;

public class TenantService : ITenantService
{
    private readonly DBContext _dbContext;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public TenantService(DBContext dbContext, IHttpContextAccessor httpContextAccessor)
    {
        _dbContext = dbContext;
        _httpContextAccessor = httpContextAccessor;
    }
    
    public async Task<Result<TenantResponseDto>> GetCurrentTenant()
    {
        try
        {
            var tenant = new TenantResponseDto
            {
                TenantId = new Guid("")
            };
            return Result<TenantResponseDto>.Success(HttpStatusCode.OK, tenant);
        }
        catch (Exception e)
        {
            return Result<TenantResponseDto>.Failed(HttpStatusCode.InternalServerError, $"Error: {e.Message} - {e.InnerException?.Message} - {e.StackTrace}.");
        }
    }
}