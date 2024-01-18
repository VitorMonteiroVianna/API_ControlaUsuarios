using AutoMapper;
using LoginApi_portifolio.Data.Dtos;
using LoginApi_portifolio.Models;

namespace LoginApi_portifolio.Profiles;

public class UsuarioProfile : Profile
{
    public UsuarioProfile()
    {
        CreateMap<CreateUsuarioDto, Usuario>();
    }
}
