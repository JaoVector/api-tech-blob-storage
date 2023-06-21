using AutoMapper;
using FarmaciaAPI.DTOS;
using FarmaciaAPI.Models;
using FarmaciaAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FarmaciaAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ImagemController : ControllerBase
{
    private readonly IUnitOfWork _uof;
    private readonly IMapper _mapper;
    public ImagemController(IMapper mapper, IUnitOfWork uof)
    {
        _uof = uof;
        _mapper = mapper;
    }


    [HttpGet]
    public ActionResult<IEnumerable<ReadImagemDTO>> GetImagens([FromQuery] int skip = 0, [FromQuery] int take = 5)
    {
        return Ok(_mapper.Map<List<ReadImagemDTO>>(_uof.ImagemRepository.Get(skip, take).ToList()));
    }

    [HttpPost(nameof(UploadImage))]
    public async Task<ActionResult> UploadImage([FromForm] ImagemDTO imagemDTO)
    {
       
        var produto = _uof.ProdutoRepository.BuscaPorID(p => p.ProdutoId == imagemDTO.ProdutoId);

        if (produto == null) return NotFound($"Não existe produto com o ID: {imagemDTO.ProdutoId}");

        var img = await _uof.ImagemRepository.UploadImage(imagemDTO);

        Imagem imagem = _mapper.Map<Imagem>(imagemDTO);

        imagem.ImagemName = imagemDTO.File.FileName; imagem.ImagemURL = img;
        
        _uof.ImagemRepository.Add(imagem);

        await _uof.Commit();

        return Ok(imagem);
        
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ReadImagemIdDTO>> BuscaPorID(int id) 
    {
        var imagem = await _uof.ImagemRepository.BuscaPorID(img => img.ImageId == id);

        if (imagem == null) return NotFound("Imagem Não Encontrada");

        ReadImagemIdDTO readImagemId = _mapper.Map<ReadImagemIdDTO>(imagem);

        return Ok(readImagemId);
    }


    [HttpDelete(nameof(DeletaImagemPelaUrl))]
    public async Task<ActionResult<ReadImagemIdDTO>> DeletaImagemPelaUrl([FromQuery] string url) 
    {
        Imagem imagem = await _uof.ImagemRepository.BuscaPorID(img => img.ImagemURL == url);

        if (imagem == null) return NotFound("Imagem Não encontrada");

        var imgDeletada = await _uof.ImagemRepository.ApagaImagem(imagem);

        if (imgDeletada == null) return NotFound("Url não Encontrada no Blob");

        _uof.ImagemRepository.Delete(imagem);
        await _uof.Commit();

        ReadImagemIdDTO readImagem = _mapper.Map<ReadImagemIdDTO>(imagem);

        return Ok(readImagem);
    }

}
