var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Static routes
app.MapGet("/", () => "Root Path");
app.MapGet("/users", () => "Users");
app.MapGet("/downloads", () => "Downloads");
app.MapPut("/", () => "This is a put request");
app.MapDelete("/", () => "This is a delete request");
app.MapPost("/", () => "This is a post request");

// Routes with parameters
app.MapGet("/users/{id:int}", (int id) => $"User ID: {id}");
app.MapGet("/names/{id}", (string id) => $"Name ID: {id}");
// min id value
app.MapGet("/products/{id::int:min(100)}", (int id) => $"Product ID: {id}");
// Handles string parameter
// app.MapGet("/products/{id}", (string id) => $"Product ID: {id}");
// Handles optional parameter
app.MapGet("/products/{id:int?}", (int? id=99) => $"Product ID: {id}");

// More complex routes
app.MapGet("/users/{id}/posts/{slug}", (string id, string slug) => {
    return $"User ID: {id} Post ID: {slug}";
    });

// Catchall route
app.MapGet("/files/{*filepath}", (string filepath) => {
    return $"File Path: {filepath}";
    });

// Route with query string parameters
app.MapGet("/search", (string? q, int page = 1) => {
    return $"Searching for: {q} on Page: {page}";
    });

app.Run();

