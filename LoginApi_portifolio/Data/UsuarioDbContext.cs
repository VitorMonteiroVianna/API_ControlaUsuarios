using LoginApi_portifolio.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoginApi_portifolio.Data;

public class UsuarioDbContext : IdentityDbContext<Usuario>
{
    public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options) : base(options) { }
}
