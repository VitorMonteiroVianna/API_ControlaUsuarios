using System.ComponentModel.DataAnnotations;

namespace LoginApi_portifolio.Data.Dtos;

public class CreateUsuarioDto
{
    [Required]
    public string Usuario { get; set; }

    [Required]
    public DateTime DataNascimento { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [Compare("Password")]
    public string ConfirmPassword { get; set; }
}
