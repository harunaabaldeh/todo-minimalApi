using TodoApi.Data;
using TodoApi.Models;

namespace TodoApi.Repository
{
    public static class DeleteTodo
    {
        public static async Task<IResult> Delete(int id, TodoDb db)
        {
            if (await db.Todos.FindAsync(id) is Todo todo)
            {
                db.Todos.Remove(todo);
                await db.SaveChangesAsync();

            }

            return TypedResults.NotFound();
        }
    }
}