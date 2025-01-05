var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Static routes
app.MapGet("/", () => "Root Path");
app.MapGet("/Users", () => "Users");
app.MapGet("/Downloads", () => "Downloads");
app.MapPut("/", () => "This is a put request");
app.MapDelete("/", () => "This is a delete request");
app.MapPost("/", () => "This is a post request");

// Routes with parameters
app.MapGet("/Users/{id:int}", (int id) => $"User ID: {id}");
app.MapGet("/Names/{id}", (string id) => $"Name ID: {id}");
app.MapGet("/Products/{id?}", (int? id=99) => $"Product ID: {id}");
app.Run();
