using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var blogs = new List<Blog> {
    new Blog { Title = "My First Post", Body = "This is my First Post"},
    new Blog { Title = "My Second Post", Body = "This is my Second Post"}
};

app.MapGet("/", () => "I am root!");
app.MapGet("/blogs", () => blogs);
app.MapGet("/blogs/{id}", (int id) => {
    if(id < 0 || id >= blogs.Count) {
        return Results.NotFound();
    } else {
        return Results.Ok(blogs[id]); // Cannot return type Blog
    }
});
app.MapPost("/blogs", (Blog blog) => {
    blogs.Add(blog);
    return Results.Created($"/blogs/{blogs.Count -1}", blog);
});
app.MapDelete("/blogs/{id}", (int id) => {
    if(id < 0 || id >= blogs.Count) {
        return Results.NotFound();
    } else {
        // var blog = blogs[id];
        blogs.RemoveAt(id);
        return Results.NoContent();
    }
});
app.MapPut("/blogs/{id}", (int id, Blog blog) => {
    if(id < 0 || id >= blogs.Count) {
        return Results.NotFound();
    } else {
        blogs[id] = blog;
        return Results.Ok(blog);
    }
});

app.Run();

public class Blog {
    public required string Title {get; set;}
    public required string Body {get; set;}
}
