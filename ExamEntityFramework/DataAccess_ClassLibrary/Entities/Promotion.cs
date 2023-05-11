using System.ComponentModel.DataAnnotations;

namespace ExamEntityFramework.Entities
{
    public class Promotion
    {
        [Key]
        public int PromotionsId { get; set; }
        [Required, MaxLength(50)]
        public string PromotionsName { get; set; }
        [Required]
        public double Discount { get; set; }
    }
}
