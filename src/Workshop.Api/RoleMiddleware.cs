using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Workshop.Api
{
    public class RoleMiddleware
    {
        private readonly RequestDelegate _next;

        public RoleMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.User.Identity is ClaimsIdentity identity)
            {
                identity.AddClaim(new Claim("roles", "Weatherman"));
            }

            await _next(httpContext);
        }
    }
}
