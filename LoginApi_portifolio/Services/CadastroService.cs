using LoginApi_portifolio.Data.Dtos;
using LoginApi_portifolio.Models;

namespace LoginApi_portifolio.Services;

public class CadastroService
{
    private object _mapper;

    public async Task CadastraUsuario(CreateUsuarioDto dto)
    {
        Usuario usuario = _mapper.Map<Usuario>(dto);

        //TODO: criar logica de cadastro de usuario
    }
}
