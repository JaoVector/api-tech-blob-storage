using AutoMapper;
using FarmaciaAPI.DTOS;
using FarmaciaAPI.Models;

namespace FarmaciaAPI.Profiles;

public class ImagemProfile : Profile
{
	public ImagemProfile()
	{
		CreateMap<ImagemDTO, Imagem>();
		CreateMap<Imagem, ReadImagemDTO>();
		CreateMap<Imagem, ReadImagemIdDTO>();
        CreateMap<ReadImagemDTO, Imagem>();
    }
}
