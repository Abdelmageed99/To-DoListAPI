namespace ToDoListAPI.Middleware
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlerMiddleware> _logger;

        public ExceptionHandlerMiddleware(RequestDelegate next, ILogger<ExceptionHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                Console.WriteLine("Custom Middleware Executing...");
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception caught in middleware: {ex.Message}");
                _logger.LogError($"Stack Trace: {ex.StackTrace}");

                context.Response.StatusCode = 500;
                context.Response.ContentType = "application/json";

                var errorResponse = new
                {
                    Message = "An unexpected error occurred.",
                    Details = ex.Message
                };

                var jsonResponse = System.Text.Json.JsonSerializer.Serialize(errorResponse);
                await context.Response.WriteAsync(jsonResponse);

            }
        }
    }
}
