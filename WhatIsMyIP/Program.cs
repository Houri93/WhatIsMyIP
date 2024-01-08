using System.Text;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", (HttpContext httpContext) => httpContext.Request.Headers["X-Forwarded-For"].ToString());

app.Run();