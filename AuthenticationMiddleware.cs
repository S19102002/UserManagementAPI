namespace UserManagementAPI.Middleware
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (!context.Request.Headers.ContainsKey("Authorization"))
            {
                context.Response.StatusCode = 401;

                await context.Response.WriteAsync(
                    "Unauthorized");

                return;
            }

            string token =
                context.Request.Headers["Authorization"];

            if (token != "Bearer TechHive123")
            {
                context.Response.StatusCode = 401;

                await context.Response.WriteAsync(
                    "Invalid Token");

                return;
            }

            await _next(context);
        }
    }
}
