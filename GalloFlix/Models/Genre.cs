using System.ComponentModel.DataAnnotations;

namespace GalloFlix.Models;

    public class Genre
    {
        [Key] // é uma anotação para a chave primária
        public byte id { get; set; }
        
        [Required] // Requerido - Not null, no banco; Torna o nome obrigatório
        [StringLength(30)] // Tamanho máximo da propriedade
        public string Name { get; set; }
    }

