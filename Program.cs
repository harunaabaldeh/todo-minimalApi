using Microsoft.EntityFrameworkCore;
using TodoApi.Data;
using TodoApi.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TodoDb>(opt => opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

var todoitems = app.MapGroup("/todoitems");

todoitems.MapGet("/", GetAllTodos.GetTodos);

todoitems.MapGet("/complete", GetCompletedTodos.CompletedTodos);

todoitems.MapGet("/{id}", GetTodo.GetTodoById);

todoitems.MapPost("/", CreateTodo.Create);

todoitems.MapPut("/todoitems/{id}", UpdateTodo.Update);

todoitems.MapDelete("/{id}", DeleteTodo.Delete);


app.Run();
