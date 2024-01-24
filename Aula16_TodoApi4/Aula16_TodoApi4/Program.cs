using Aula16_TodoApi4.Data;
using Aula16_TodoApi4.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TodoDb>(opt => opt.UseInMemoryDatabase("TodoList"));


var app = builder.Build();
app.MapGet("/", () => "Hello World");
//listar todos
app.MapGet("/todoitems", async (TodoDb db) => await db.Todos.ToListAsync());
//listar completos
app.MapGet("/todoitems/complete", async (TodoDb db) =>
await db.Todos.Where(t => t.IsComplete).ToListAsync());

//listar por id
app.MapGet("/todoitems/{id}", async (int id, TodoDb db) =>
await db.Todos.FindAsync(id)
    is Todo todo
    ? Results.Ok(todo)
    : Results.NotFound());
    
//postar valor
app.MapPost("/todoitems", async (Todo todo, TodoDb db) =>
{
    db.Todos.Add(todo);
    await db.SaveChangesAsync();
    return Results.Created($"/todoitem/{todo.Id}", todo);
});

//deletar valor
app.MapDelete("/todoitems/{id}", async (int id, TodoDb db) =>
{
    if (await db.Todos.FindAsync(id) is Todo todo)
    {
        db.Todos.Remove(todo);
        await db.SaveChangesAsync();
        return Results.NoContent();
    }
    return Results.NotFound();
}
);

//alterar valor
app.MapPut("/todoitems/{id}", async (int id, Todo inputTodo, TodoDb db) =>
{
    var todo = await db.Todos.FindAsync(id);

    if (todo is null) return Results.NotFound();

    todo.Name = inputTodo.Name;
    todo.IsComplete = inputTodo.IsComplete;

    await db.SaveChangesAsync();

    return Results.NoContent();
});

app.Run();