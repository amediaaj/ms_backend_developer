var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpLogging((o) => {});

var app = builder.Build();

// Behind the scenes .NET
// app.UseRouting()

// More middleware automagically based on services conditionally
// app.UseAuthentication()
// app.UseAuthorization

// app.UseExceptionHandler

app.Use(async (context, next) => {
    Console.WriteLine("Logic before 1");
    await next.Invoke();
    Console.WriteLine("Logic after 1");
});
app.Use(async (context, next) => {
    Console.WriteLine("Logic before 2");
    await next.Invoke();
    Console.WriteLine("Logic after 2");
});
app.Use(async (context, next) => {
    Console.WriteLine("Logic before 3");
    await next.Invoke();
    Console.WriteLine("Logic after 3");
});
app.UseHttpLogging();

app.MapGet("/", () => "Hello World!");
app.MapGet("/hello", () => "This is the hello route");

// Behind the scenes .NET
// app.UseEndpoints()

app.Run();
