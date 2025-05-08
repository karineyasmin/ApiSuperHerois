using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHerois.Api.Entities;

public class Filme
{
    [Key]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "O filme é obrigatório")]
    public string? Titulo { get; set; }
    public string? Descricao { get; set; }
    public string? Diretor { get; set; }
    public DateTime Lancamento { get; set; }

    [ForeignKey("SuperHeroId")]
    public Guid SuperHeroiId { get; set; }
    public SuperHeroi? SuperHeroi { get; set; }
}
