namespace DzEntityFramework2.Entities
{
    public class Shops
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public int? ParkingArea { get; set; }
    }
}
