using Microsoft.EntityFrameworkCore;
using TodoApi.Data;
using TodoApi.DTOs;

namespace TodoApi.Services
{
    public static class GetAllTodos
    {
        public static async Task<IResult> GetTodos(TodoDb db)
        {
            return TypedResults.Ok(await db.Todos.Select(x => new TodoItemDto(x)).ToListAsync());
        }
    }
}