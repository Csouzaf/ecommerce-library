using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ecommerceLivraria.Models
{
    public class ProdutosModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = string.Empty;
        
        public string Nome { get; set; } = string.Empty;
        
        public double Preco { get; set; }
        
        public int Quant { get; set; }
       
        public string Categoria { get; set; } = string.Empty;
        public string Img { get; set; } = string.Empty;

    }
}