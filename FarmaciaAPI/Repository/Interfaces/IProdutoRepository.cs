using FarmaciaAPI.DTOS;
using FarmaciaAPI.Models;

namespace FarmaciaAPI.Repository.Interfaces;

public interface IProdutoRepository : IRepository<Produtos>
{
    Task ApagaImagens(Imagem imagem);
}
