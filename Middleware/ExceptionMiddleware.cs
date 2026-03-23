namespace Microloand.API.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                // TODO: Handle exception properly
                context.Response.StatusCode = 500;

                await context.Response.WriteAsync("Something went wrong");
            }
        }
    }
}