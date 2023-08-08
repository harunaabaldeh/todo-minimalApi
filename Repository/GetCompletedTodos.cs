using Microsoft.EntityFrameworkCore;
using TodoApi.Data;
using TodoApi.DTOs;

namespace TodoApi.Repository
{
    public static class GetCompletedTodos
    {
        public static async Task<IResult> CompletedTodos(TodoDb db)
        {
            return TypedResults.Ok(await db.Todos.Where(t => t.IsComplete)
                    .Select(x => new TodoItemDto(x)).ToListAsync());
        }
    }
}