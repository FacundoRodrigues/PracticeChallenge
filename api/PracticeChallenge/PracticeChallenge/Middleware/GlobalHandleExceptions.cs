namespace PracticeChallenge.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class GlobalHandleExceptions
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public GlobalHandleExceptions(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<GlobalHandleExceptions>();
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString(), ex);
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class GlobalHandleExceptionsExtensions
    {
        public static IApplicationBuilder UseGlobalHandleExceptions(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<GlobalHandleExceptions>();
        }
    }
}