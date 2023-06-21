using FarmaciaAPI.DTOS;
using FarmaciaAPI.Models;

namespace FarmaciaAPI.Repository.Interfaces;

public interface IImagemRepository : IRepository<Imagem>
{
    Task<string> UploadImage(ImagemDTO imagemDTO);
    Task<string> ApagaImagem(Imagem imagem);
}
