using TodoApi.Data;
using TodoApi.Models;

namespace TodoApi.Services
{
    public static class UpdateTodo
    {
        public static async Task<IResult> Update(int id, Todo inputTodod, TodoDb db)
        {
            var todo = await db.Todos.FindAsync(id);

            if (todo is null) return TypedResults.NotFound();

            todo.Name = inputTodod.Name;
            todo.IsComplete = inputTodod.IsComplete;

            await db.SaveChangesAsync();

            return TypedResults.NoContent();
        }
    }
}