using System.ComponentModel.DataAnnotations;

namespace ExamEntityFramework.Entities
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        [Required, MaxLength(50)]
        public string GenreName { get; set; }
    }
}
