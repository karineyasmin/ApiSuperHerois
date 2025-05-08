using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SuperHerois.Api.Entities;

public class SuperPoder
{
    [Key]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Informe o super poder")]
    public string? Super_Poder { get; set; }

    public string? Descricao { get; set; }

    [ForeignKey("SuperHeroiId")]
    public Guid SuperHeroiId { get; set; }


    public SuperHeroi? SuperHeroi { get; set; }

}
