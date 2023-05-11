using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamEntityFramework.Entities
{
    public class Credential
    {
        [Key]
        public int ClientId { get; set; }
        [Required, MaxLength(50)]
        public string Login { get; set; }
        [Required, MaxLength(50), PasswordPropertyText]
        public string Password { get; set; }
    }
}
