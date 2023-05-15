using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloFlix.Models;

    public class Movie
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(100)]

        public string Title { get; set; }
         [Required]
        [StringLength(100)]

        public string OriginalTitle { get; set; }
         [Required]
        [StringLength(800)]
        public string Synopsis { get; set; }
         [Required]
        [StringLength(100)]

        public Int16 MovieYear { get; set; }
        [Required]
        [StringLength(100)]

        public Int16 Duration { get; set; }
        [Required]
        [StringLength(100)]

        public byte AgeRating { get; set; } = 0;
    
        [StringLength(200)]
        public string Image { get; set; }
    
        [NotMapped]
        public string HourDuration { get {
            return TimeSpan.FromMinutes(Duration).ToString(@"%h 'h'mm'min'");
        } }
    }
