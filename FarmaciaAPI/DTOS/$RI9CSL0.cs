namespace FarmaciaAPI.DTOS;

public class ReadImagemIdDTO
{

    public int ImageId { get; set; }
    public int ProdutoId { get; set; }
    public string? ImagemName { get; set; }
    public string? ImagemURL { get; set; }

}
