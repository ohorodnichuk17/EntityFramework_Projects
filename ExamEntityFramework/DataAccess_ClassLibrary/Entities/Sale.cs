using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamEntityFramework.Entities
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        [ForeignKey("Client")]
        public int CLientId { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
