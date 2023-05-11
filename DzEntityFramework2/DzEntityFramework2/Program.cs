using DzEntityFramework2.Entities;
using System;
using System.Linq;

namespace DzEntityFramework2
{
    internal class Program
    {
        static void GetAllCities()
        {
            using (var dbContext = new ShopDbContext())
            {
                var cities = dbContext.Cities.ToList();
                Console.WriteLine("Cities: ");
                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Id} - {city.Name} - {city.CountryId}");
                }
            }
        }

        static void GetAllCountries()
        {
            using (var dbContext = new ShopDbContext())
            {
                var countries = dbContext.Countries.ToList();
                Console.WriteLine("Countries: ");
                foreach (var country in countries)
                {
                    Console.WriteLine($"{country.Id} - {country.Name}");
                }
            }
        }


        static void GetAllCategories()
        {
            using (var dbContext = new ShopDbContext())
            {
                var categories = dbContext.Categories.ToList();
                Console.WriteLine("Categories: ");
                foreach (var category in categories)
                {
                    Console.WriteLine($"{category.Id} - {category.Name}");
                }
            }
        }


        static void GetAllProducts()
        {
            using (var dbContext = new ShopDbContext())
            {
                var products = dbContext.Products.ToList();
                Console.WriteLine("Products: ");
                foreach (var product in products)
                {
                    Console.WriteLine($"{product.Id} - {product.Name} - {product.Price} - {product.Discount} - {product.CategoryId} - {product.Quantity} - {product.IsInStock}");
                }
            }
        }

        static void GetAllPositions()
        {
            using (var dbContext = new ShopDbContext())
            {
                var positions = dbContext.Positions.ToList();
                Console.WriteLine("Positions: ");
                foreach (var position in positions)
                {
                    Console.WriteLine($"{position.Id} - {position.Name}");
                }
            }
        }

        static void GetAllWorkers()
        {
            using (var dbContext = new ShopDbContext())
            {
                var workers = dbContext.Workers.ToList();
                Console.WriteLine("Workers: ");
                foreach (var worker in workers)
                {
                    Console.WriteLine($"{worker.Id} - {worker.Name} - {worker.Surname} - {worker.Salary} - {worker.Email} - {worker.PhoneNumber} - {worker.PositionId} - {worker.ShopId}");
                }
            }
        }

        static void GetAllShops()
        {
            using (var dbContext = new ShopDbContext())
            {
                var shops = dbContext.Shops.ToList();
                Console.WriteLine("Shops: ");
                foreach (var shop in shops)
                {
                    Console.WriteLine($"{shop.Id} - {shop.Name} - {shop.Address} - {shop.CityId} - {shop.ParkingArea}");
                }
            }
        }

        static void Main(string[] args)
        {
            ShopDbContext context = new ShopDbContext();

            if (context.Database.CanConnect())
            {
                Console.WriteLine("Connection successful");
            }
            else
            {
                Console.WriteLine("Connection failed");
            }

            int num = 0;

            do
            {
                Console.WriteLine("[1] - Display all information about countries");
                Console.WriteLine("[2] - Display all information about cities");
                Console.WriteLine("[3] - Display all information about categories");
                Console.WriteLine("[4] - Display all information about products");
                Console.WriteLine("[5] - Display all information about positions");
                Console.WriteLine("[6] - Display all information about workers");
                Console.WriteLine("[7] - Display all information about shops");
                Console.WriteLine("[0] - Exit");
                num = int.Parse(Console.ReadLine());

                switch(num)
                {
                    case 1: GetAllCountries(); break;
                    case 2: GetAllCities(); break;
                    case 3: GetAllCategories(); break;
                    case 4: GetAllProducts(); break;
                    case 5: GetAllPositions(); break;
                    case 6: GetAllWorkers(); break;
                    case 7: GetAllShops(); break;
                    case 0: Environment.Exit(0); break;
                    default:
                        Console.WriteLine("Error!!!");
                        break;
                }
            } while (num != 0);
        }
    }
}
