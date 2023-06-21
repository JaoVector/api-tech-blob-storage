using FarmaciaAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace FarmaciaAPI.DTOS;

public class ProdutoDTO
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
}
