var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Root Path");
app.MapGet("/Downloads", () => "Downloads");
app.MapPut("/", () => "This is a put request");
app.MapDelete("/", () => "This is a delete request");
app.MapPost("/", () => "This is a post request");

app.Run();
