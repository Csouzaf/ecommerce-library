using Microsoft.EntityFrameworkCore;

namespace ecommerceLivraria.Models
{
    public class ToDoContextModel : DbContext
    {
      
        public ToDoContextModel(DbContextOptions<ToDoContextModel> options) : base(options) 
        {
        
           
            
        }

        public DbSet<ProdutosModel> produtos { get; set; }
    }
}