using FarmaciaAPI.DTOS;
using System.ComponentModel.DataAnnotations;

namespace FarmaciaAPI.Models;

public class Produtos
{
    [Key]
    [Required]
    public int ProdutoId { get; set; }
    [Required]
    [StringLength(60)]
    public string Nome { get; set; }
    [Required]
    [StringLength(60)]
    public string Descricao { get; set; }
    [Required]
    public decimal Preco { get; set; }
    [Required]
    [StringLength(300, MinimumLength = 10)]
    public virtual ICollection<Imagem>? Imagens { get; set; }

}
