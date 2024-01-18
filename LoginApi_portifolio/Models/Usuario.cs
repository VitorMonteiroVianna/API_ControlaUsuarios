using Microsoft.AspNetCore.Identity;

namespace LoginApi_portifolio.Models;

public class Usuario : IdentityUser
{
    public DateTime DataNascimento { get; set; }
    public Usuario() : base() { }
}
