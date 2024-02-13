using Microsoft.EntityFrameworkCore;

namespace ToDoApi
{
    class TodoDb : DbContext
    {
       public TodoDb(DbContextOptions<TodoDb> options) 
            : base(options) { }
       public DbSet<Todo> Todos => Set<Todo>();
    }
}
