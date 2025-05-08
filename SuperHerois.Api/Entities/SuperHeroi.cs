using System.ComponentModel.DataAnnotations;

namespace SuperHerois.Api.Entities;

public class SuperHeroi
{
    [Key]
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Informe o nome do Super Herói")]
    public string? Nome { get; set; }
    public string? Descricao { get;set;}
    public double Altura { get; set;}

    [UseSorting]
    public ICollection<SuperPoder>? SuperPoderes { get; set; }

    [UseSorting]
    public ICollection<Filme>? Filmes { get; set;}

}
