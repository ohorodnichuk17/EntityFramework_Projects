using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamEntityFramework.Entities
{
    public class Tray
    {
        [Key]
        public int TrayId { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        [Required]
        public int Amount { get; set; }
    }
}
