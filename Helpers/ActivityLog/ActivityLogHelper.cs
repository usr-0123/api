using api.Data;
using api.DTO.ActivityLog;

namespace api.Helpers.ActivityLog
{
    public class ActivityLogHelper
    {
        public static void AddActivityLog(ActivityLogDto dto, DBContext context,
            IHttpContextAccessor httpContextAccessor)
        {
            var requestIpAddress = httpContextAccessor.HttpContext.Connection.RemoteIpAddress?.ToString();
            var requestUserAgent = httpContextAccessor.HttpContext.Request.Headers["User-Agent"].ToString();
            var requestReferer = httpContextAccessor.HttpContext.Request.Headers["Referer"].ToString();
            var requestUrl = httpContextAccessor.HttpContext.Request.Path.ToString();
            var requestQueryString = httpContextAccessor.HttpContext.Request.QueryString.ToString();
            var auth = httpContextAccessor.HttpContext.Items["authenticatedUser"] as AuthenticatedUser;
            var createdBy = auth?.UserId;

            var activityLog = new Models.ActivityLog.ActivityLog
            {
                ActivityType = dto.ActivityType,
                Description = dto.Description,
                Email = dto.Email,
                OldValue = dto.OldValue,
                NewValue = dto.NewValue,
                IpAddress = dto.IpAddress,
                UserAgent = dto.UserAgent,
                Referrer = dto.Referrer,
                Url = dto.Url,
                QueryString = requestQueryString,
                RequestBody = dto.RequestBody,
                CreatedBy = createdBy,
                CreatedAt = DateTime.UtcNow,
                TenantId = auth?.TenantId == null ? new Guid("") : auth.TenantId
            };

            context.ActivityLogs.Add(activityLog);
            context.SaveChanges();
        }
    }
}