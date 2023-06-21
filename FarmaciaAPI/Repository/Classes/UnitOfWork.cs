using Azure.Storage.Blobs;
using FarmaciaAPI.Context;
using FarmaciaAPI.Repository.Interfaces;

namespace FarmaciaAPI.Repository.Classes;

public class UnitOfWork : IUnitOfWork
{

    private ProdutoRepository _produtoRepository;
    private ImagemRepository _imagemRepository;

    public FContext _context;

    private readonly BlobServiceClient _blobService;

    public UnitOfWork(FContext Fcontext, BlobServiceClient blobService)
    {
        _context = Fcontext;
        _blobService = blobService;
       
    }

    public IProdutoRepository ProdutoRepository 
    {
        get 
        {
            return _produtoRepository = _produtoRepository ?? new ProdutoRepository(_context, _blobService);
        }
    }

    public IImagemRepository ImagemRepository 
    {
        get 
        {
            return _imagemRepository = _imagemRepository ?? new ImagemRepository(_context, _blobService);
        }
    }

    public async Task Commit()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose() 
    {
        _context.Dispose();
    }
}
