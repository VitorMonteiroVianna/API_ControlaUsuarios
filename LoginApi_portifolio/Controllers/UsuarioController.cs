using LoginApi_portifolio.Data.Dtos;
using LoginApi_portifolio.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoginApi_portifolio.Controllers;


[ApiController]
[Route("[Controler]")]

public class UsuarioController : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dto)
    {
        await _cadastroService.CadastraUsuario(dto);
        //TODO: Corrigir logica da controladora
    }
}
