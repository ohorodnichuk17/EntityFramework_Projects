namespace DzEntityFramework2.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Discount { get; set; }
        public int? CategoryId { get; set; }
        public int Quantity { get; set; }
        public bool IsInStock { get; set; }
    }
}
