namespace FarmaciaAPI.Repository.Interfaces;

public interface IUnitOfWork
{
    IProdutoRepository ProdutoRepository { get; }
    IImagemRepository ImagemRepository { get; }
    Task Commit();
}
