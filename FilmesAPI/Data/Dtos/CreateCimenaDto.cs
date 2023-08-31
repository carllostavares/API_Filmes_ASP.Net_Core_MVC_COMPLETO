using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class CreateCimenaDto
{
    [Required(ErrorMessage = "O campo é obrigatório!")]
    public string Nome { get; set; }
}
