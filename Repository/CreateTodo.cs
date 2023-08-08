using TodoApi.Data;
using TodoApi.DTOs;
using TodoApi.Models;

namespace TodoApi.Repository
{
    public static class CreateTodo
    {
        public static async Task<IResult> Create(TodoItemDto todoItemDto, TodoDb db)
        {
            var todoItem = new Todo
            {
                IsComplete = todoItemDto.IsComplete,
                Name = todoItemDto.Name
            };

            db.Todos.Add(todoItem);
            await db.SaveChangesAsync();

            return TypedResults.Created($"/todoitems/{todoItem.Id}", todoItemDto);
        }
    }
}