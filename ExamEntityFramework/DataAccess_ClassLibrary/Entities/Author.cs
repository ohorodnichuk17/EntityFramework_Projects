using System.ComponentModel.DataAnnotations;

namespace ExamEntityFramework.Entities
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [Required, MaxLength(40)]
        public string Name { get; set; }
        [Required, MaxLength(40)]
        public string Surname { get; set; }
    }
}
