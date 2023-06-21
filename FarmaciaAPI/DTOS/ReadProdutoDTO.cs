using FarmaciaAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace FarmaciaAPI.DTOS;

public class ReadProdutoDTO
{
    public int ProdutoId { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
    public DateTime DataConsulta { get; set; } = DateTime.Now;
    public virtual ICollection<ReadImagemDTO>? Imagens { get; set; }
}
