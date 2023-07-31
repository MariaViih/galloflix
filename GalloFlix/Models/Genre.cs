using System.ComponentModel.DataAnnotations;

namespace GalloFlix.Models;

public class Genre
{
    [Key]  // É uma anotação para chave primária
    public byte Id { get; set; }
     [Display(Name = "Nome")]
    [Required] // Requerido - Not Null no banco; Torna o nome obrigatório
    [StringLength(30)] // Tamanho máximo da propriedade
    public string Name { get; set; }
    public ICollection<MovieGenre> Movies { get; set; }
}

