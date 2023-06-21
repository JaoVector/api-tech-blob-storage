using Castle.Components.DictionaryAdapter;
using FarmaciaAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace FarmaciaAPI.DTOS;

public class ImagemDTO
{
    public int ProdutoId { get; set; }
    public IFormFile File { get; set; }
}
