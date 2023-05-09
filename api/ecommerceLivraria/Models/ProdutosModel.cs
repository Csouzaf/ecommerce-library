using System.ComponentModel.DataAnnotations;
namespace ecommerceLivraria.Models
{
    public class ProdutosModel
    {
        public string Id { get; set; }
        // [RequiredAttribute(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quant { get; set; }
        public string Categoria { get; set; }
        public string Img { get; set; }

    }
}