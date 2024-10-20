namespace SimpleWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            // Middleware
            app.Use(async (context, next) =>
            {
                var startTime = DateTime.UtcNow;
                await next.Invoke();
                var endTime = DateTime.UtcNow;
                var processingTime = endTime - startTime;
                Console.WriteLine($"Request processing time: {processingTime.TotalMilliseconds} ms");
            });

            app.MapGet("/", () => "Hello World!");

            app.MapGet("/about", () => "This is a simple ASP.NET Core application.");

            app.MapPost("/echo", async (HttpContext context) =>
            {
                context.Response.ContentType = "application/json";
                using var reader = new StreamReader(context.Request.Body);
                var body = await reader.ReadToEndAsync();
                await context.Response.WriteAsync(body);
            });

            app.Run();
        }
    }
}
