using Microsoft.EntityFrameworkCore;

namespace ecommerceLivraria.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) {

        }

        public DbSet<Produtos> produtos { get; set; }
    }
}