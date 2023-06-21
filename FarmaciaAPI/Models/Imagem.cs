using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace FarmaciaAPI.Models;

public class Imagem
{
    [Key]
    public int ImageId { get; set; }
    public int ProdutoId { get; set; }
    public string? ImagemName { get; set; }
    public string? ImagemURL { get; set; }
    [JsonIgnore]
    [IgnoreDataMember]
    public virtual Produtos? Produto { get; set; }
}
