// Add using statements
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

// 3. Register the Service in Program.cs

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IMyService, MyService>();

var app = builder.Build();

// After building add middleware

// The middleware retrieves the IMyService instance and logs its use in two parts
// of the pipeline. Since IMyService is registered as a singleton, the same instance
// will be reused.
app.Use(async (context, next) => 
{
    var myService = context.RequestServices.GetRequiredService<IMyService>();
    myService.LogCreation("First Middleware");
    await next();
});

app.Use(async (context, next) => 
{
    var myService = context.RequestServices.GetRequiredService<IMyService>();
    myService.LogCreation("Second Niddleware");
    await next();
});

// This route logs a message with LogCreation and returns a message indicating that logs
// should appear in the console.
app.MapGet("/", (IMyService MyService) => {
    MyService.LogCreation("Root");
    return Results.Ok("Check the console for service creation logs.");
});

app.Run();
