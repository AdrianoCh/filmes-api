using AutoMapper;
using filmes_api.Data.Dtos;
using filmes_api.Models;

namespace FilmesApi.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>();
    }
}