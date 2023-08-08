using TodoApi.Data;
using TodoApi.Models;

namespace TodoApi.Services
{
    public static class GetTodo
    {
        public static async Task<IResult> GetTodoById(int id, TodoDb db)
        {
            return await db.Todos.FindAsync(id) is Todo todo ? TypedResults.Ok(todo) : TypedResults.NotFound();
        }
    }
}