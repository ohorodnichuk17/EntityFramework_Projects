using System.ComponentModel.DataAnnotations;

namespace ExamEntityFramework.Entities
{
    public class Publishing
    {
        [Key]
        public int PublishingId { get; set; }
        [Required, MaxLength(50)]
        public string PublishingName { get; set; }
    }
}
