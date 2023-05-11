using DzEntityFramework2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzEntityFramework2
{

    internal class ShopDbContext : DbContext
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<City> Cities  { get; set; }
        public DbSet<Countries> Countries  { get; set; }
        public DbSet<Positions> Positions  { get; set; }
        public DbSet<Products> Products  { get; set; }
        public DbSet<Shops> Shops  { get; set; }
        public DbSet<Workers> Workers  { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=JULIAOHORODNICH\SQLEXPRESS;
                                          Initial Catalog=ShopsDb;
                                          Integrated Security=True;
                                          Connect Timeout=2;
                                          Encrypt=False;
                                          TrustServerCertificate=False;
                                          ApplicationIntent=ReadWrite;
                                          MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Categories>().HasData(new Categories[]
            {
                new Categories()
                {
                    Id = 1,
                    Name = "Electronics"
                },
                  new Categories()
                {
                    Id = 2,
                    Name = "Clothing"
                },
                    new Categories()
                {
                    Id = 3,
                    Name = "Shoes"
                },
                      new Categories()
                {
                    Id = 4,
                    Name = "Toys"
                },
                        new Categories()
                {
                    Id = 5,
                    Name = "Books"
                }
            });

            modelBuilder.Entity<City>().HasData(new City[]
            {
                new City()
                {
                    Id = 1,
                    Name = "Rivne",
                    CountryId = 1
                },
                new City()
                {
                    Id = 2,
                    Name = "Kyiv",
                    CountryId = 1
                },
                new City()
                {
                    Id = 3,
                    Name = "Warsawa",
                    CountryId = 3
                },
                new City()
                {
                    Id = 4,
                    Name = "London",
                    CountryId = 5
                },
                new City()
                {
                    Id = 5,
                    Name = "New-York",
                    CountryId = 2
                },
               new City()
                {
                    Id = 6,
                    Name = "Krakiv",
                    CountryId = 3
                },
                new City()
                {
                    Id = 7,
                    Name = "Berlin",
                    CountryId = 4
                }
            });

            modelBuilder.Entity<Countries>().HasData(new Countries[]
            {
                new Countries()
                {
                    Id = 1,
                    Name = "Ukraine"
                },
                new Countries()
                {
                    Id = 2,
                    Name = "USA"
                },
                new Countries()
                {
                    Id = 3,
                    Name = "Poland"
                },
                new Countries()
                {
                    Id = 4,
                    Name = "Germany"
                },
                new Countries()
                {
                    Id = 5,
                    Name = "Great-Britain"
                }
            });

            modelBuilder.Entity<Positions>().HasData(new Positions[]
            {
                new Positions()
                {
                    Id = 1,
                    Name = "Cashier"
                },
                new Positions()
                {
                    Id = 2,
                    Name = "Consultant"
                },
                new Positions()
                {
                    Id = 3,
                    Name = "Security Guard"
                },
                new Positions()
                {
                    Id = 4,
                    Name = "Shop Manager"
                }
            });

            modelBuilder.Entity<Shops>().HasData(new Shops[]
            {
                new Shops()
                {
                    Id = 1,
                    Name = "Apple",
                    Address = "912 Park Ave",
                    CityId = 5,
                    ParkingArea = 5,
                },
                new Shops()
                {
                    Id = 2,
                    Name = "Toys",
                    Address = "2336 Jack Warren Rd",
                    CityId = 4,
                    ParkingArea = 20,
                },
                new Shops()
                {
                    Id = 3,
                    Name = "Nike",
                    Address = "1105 Aztec Rd",
                    CityId = 6,
                    ParkingArea = 15,
                },
                new Shops()
                {
                    Id = 4,
                    Name = "H&M",
                    Address = "23475 Glacier View Dr",
                    CityId = 2,
                    ParkingArea = 10,
                },
                new Shops()
                {
                    Id = 5,
                    Name = "Adidas",
                    Address = "527 Pond Reef Rd",
                    CityId = 7,
                    ParkingArea = 8,
                },
                new Shops()
                {
                    Id = 6,
                    Name = "Products",
                    Address = "2425 Hc 1",
                    CityId = 1,
                    ParkingArea = 5,
                },
                new Shops()
                {
                    Id = 7,
                    Name = "Armani",
                    Address = "821 Ridge Top Cir",
                    CityId = 3,
                    ParkingArea = 9,
                }
            });

            modelBuilder.Entity<Workers>().HasData(new Workers[]
            {
                new Workers()
                {
                    Id = 1,
                    Name = "Dante",                                                                                           
                    Surname = "Hayden",
                    Salary = 23839,
                    Email = "dantehayden@gmail.com",
                    PhoneNumber = "+380958290282",
                    PositionId = 2,
                    ShopId = 3,
                },
                new Workers()
                {
                    Id = 2,
                    Name = "Hermione",
                    Surname = "Atkins",
                    Salary = 40999,
                    Email = "hermoineatkins@gmail.com",
                    PhoneNumber = "+380689270283",
                    PositionId = 4,
                    ShopId = 7,
                },
                new Workers()
                {
                    Id = 3,
                    Name = "Rehan",
                    Surname = "Robinson",
                    Salary = 18203,
                    Email = "rehanrobinson@gmail.com",
                    PhoneNumber = "+380508292728",
                    PositionId = 2,
                    ShopId = 6,
                },
                new Workers()
                {
                    Id = 4,
                    Name = "Cassandra",
                    Surname = "Bolton",
                    Salary = 12820,
                    Email = "cassandrabolton@gmail.com",
                    PhoneNumber = "+380631749173",
                    PositionId = 3,
                    ShopId = 2,
                },
               new Workers()
                {
                    Id = 5,
                    Name = "Maliha",
                    Surname = "Snow",
                    Salary = 15200,
                    Email = "malihasnow@gmail.com",
                    PhoneNumber = "+380679272649",
                    PositionId = 1,
                    ShopId = 5,
                },
                new Workers()
                {
                    Id = 6,
                    Name = "Hope",
                    Surname = "Navarro",
                    Salary = 11203,
                    Email = "hopenavarro@gmail.com",
                    PhoneNumber = "+380958294727",
                    PositionId = 1,
                    ShopId = 1,
                },
                new Workers()
                {
                    Id = 7,
                    Name = "Raphael",
                    Surname = "Slater",
                    Salary = 9103,
                    Email = "raphaelslater@gmail.com",
                    PhoneNumber = "+380982748265",
                    PositionId = 3,
                    ShopId = 4,
                },
                new Workers()
                {
                    Id = 8,
                    Name = "Max",
                    Surname = "Cervantes",
                    Salary = 38294,
                    Email = "maxcervantes@gmail.com",
                    PhoneNumber = "+380681492048",
                    PositionId = 4,
                    ShopId = 3,
                }
            });

            modelBuilder.Entity<Products>().HasData(new Products[]
            {
                new Products()
                {
                    Id = 1,
                    Name = "Hoodie",
                    Price = 1300,
                    Discount = 10,
                    CategoryId = 5,
                    Quantity = 10,
                    IsInStock = true,
                },
                new Products()
                {
                    Id = 2,
                    Name = "iPhone",
                    Price = 99,
                    Discount = 3,
                    CategoryId = 1,
                    Quantity = 10,
                    IsInStock = true,
                },
                new Products()
                {
                    Id = 3,
                    Name = "Lego",
                    Price = 1990,
                    Discount = 199,
                    CategoryId = 2,
                    Quantity = 7,
                    IsInStock = false,
                },
                new Products()
                {
                    Id = 4,
                    Name = "Jeans",
                    Price = 600,
                    Discount = 0,
                    CategoryId = 7,
                    Quantity = 10,
                    IsInStock = true,
                },
                new Products()
                {
                    Id = 5,
                    Name = "Ball",
                    Price = 400,
                    Discount = 1,
                    CategoryId = 2,
                    Quantity = 4,
                    IsInStock = true,
                },
                new Products()
                {
                    Id = 6,
                    Name = "Chips",
                    Price = 34,
                    Discount = 2,
                    CategoryId = 5,
                    Quantity = 8,
                    IsInStock = false,
                },
                new Products()
                {
                    Id = 7,
                    Name = "Socks",
                    Price = 1200,
                    Discount = 700,
                    CategoryId = 3,
                    Quantity = 10,
                    IsInStock = true,
                },
                new Products()
                {
                    Id = 8,
                    Name = "Glasses",
                    Price = 5028,
                    Discount = 1399,
                    CategoryId = 4,
                    Quantity = 8,
                    IsInStock = true,
                },
                new Products()
                {
                    Id = 9,
                    Name = "Cheese",
                    Price = 120,
                    Discount = 0,
                    CategoryId = 5,
                    Quantity = 2,
                    IsInStock = false,
                },
                new Products()
                {
                    Id = 10,
                    Name = "Hand Cream",
                    Price = 600,
                    Discount = 8,
                    CategoryId = 3,
                    Quantity = 9,
                    IsInStock = true,
                }
            });

            modelBuilder.Entity<Categories>().Property(c => c.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<City>().Property(c => c.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Countries>().Property(c => c.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Positions>().Property(p => p.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Shops>().Property(s => s.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Shops>().Property(s => s.Address).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Workers>().Property(w => w.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Workers>().Property(w => w.Surname).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Workers>().Property(w => w.Salary).IsRequired();
            modelBuilder.Entity<Workers>().Property(w => w.Email).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Workers>().Property(w => w.PhoneNumber).HasMaxLength(50).IsRequired();
        }
    }
}
