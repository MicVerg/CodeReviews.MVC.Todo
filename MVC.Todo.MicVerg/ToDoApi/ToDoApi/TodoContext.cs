using Microsoft.EntityFrameworkCore;

namespace ToDoApi
{
    class TodoContext : DbContext
    {
       public TodoContext(DbContextOptions<TodoContext> options) 
            : base(options) { }
       public DbSet<Todo> Todos => Set<Todo>();
    }
}
