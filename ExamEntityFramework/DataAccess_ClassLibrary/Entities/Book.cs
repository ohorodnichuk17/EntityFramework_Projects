using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamEntityFramework.Entities
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required, MaxLength(40)]
        public string BookName { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        [ForeignKey("Publishing")]
        public int PublishingId { get; set; }
        [Required]
        public int AmountOfPages { get; set; }
        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        [Required]
        public int PublishingYear { get; set; }
        [Required]
        public double Cost { get; set; }
        [Required]
        public double PriceToSell { get; set; }
    }
}
