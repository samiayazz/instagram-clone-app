using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace InstagramClone.Persistence.Utils.AspNetCore
{
    public class HttpContextUtils
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HttpContextUtils(IHttpContextAccessor httpContextAccessor)
            => _httpContextAccessor = httpContextAccessor;

        public Guid GetCurrentUserId()
        {
            var httpContextUser = _httpContextAccessor.HttpContext?.User;
            ArgumentNullException.ThrowIfNull(httpContextUser, nameof(httpContextUser));

            string? httpContextUserId = httpContextUser.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!Guid.TryParse(httpContextUserId, out var userId))
                ArgumentException.ThrowIfNullOrEmpty(httpContextUserId, nameof(httpContextUserId));

            return userId;
        }
    }
}