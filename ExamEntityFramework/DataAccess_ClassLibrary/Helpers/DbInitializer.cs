using ExamEntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ExamEntityFramework.Helpers
{
    public static class DbInitializer
    {
        public static void SeedAuthors(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[] 
            {
                new Author
                {
                    AuthorId = 1,
                    Name = "Edward",
                    Surname = "Sweeney"
                },
                new Author
                {
                    AuthorId = 2,
                    Name = "Elodie",
                    Surname = "Richardson"
                },
                new Author
                {
                    AuthorId = 3,
                    Name = "Harley",
                    Surname = "Bloggs"
                },
                new Author
                {
                    AuthorId = 4,
                    Name = "Saba",
                    Surname = "Vaughan"
                },
                new Author
                {
                    AuthorId = 5,
                    Name = "Ada",
                    Surname = "Hahn"
                },
                new Author
                {
                    AuthorId = 6,
                    Name = "Christine",
                    Surname = "Kirby"
                }
            });
        }
      
        public static void SeedGenres(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(new Genre[]
            {
                new Genre
                { 
                     GenreId = 1,
                     GenreName = "Fantasy"
                },
                new Genre
                {
                     GenreId = 2,
                     GenreName = "Mystery"
                },
                new Genre
                {
                     GenreId = 3,
                     GenreName = "Romance"
                },
                new Genre
                {
                     GenreId = 4,
                     GenreName = "Westerns"
                },
                new Genre
                {
                     GenreId = 5,
                     GenreName = "Dystopian"
                }
            });
        }

        public static void SeedPublishings(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Publishing>().HasData(new Publishing[]
            {
                new Publishing
                {
                    PublishingId = 1,
                    PublishingName = "Brainy Publications"
                },
                new Publishing
                {
                    PublishingId = 2,
                    PublishingName = "Ink n Paper Press"
                },
                new Publishing
                {
                    PublishingId = 3,
                    PublishingName = "Wordsmith Literature"
                }
            });
        }

        public static void SeedBooks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(new Book[]
            {
                new Book
                {
                     BookId = 1,
                     AuthorId = 3,
                     AmountOfPages = 382,
                     BookName = "Warrior Of The Curse",
                     Cost = 299,
                     GenreId = 4,
                     PriceToSell = 400,
                     PublishingId = 2,
                     PublishingYear = 2023
                },
                new Book
                {
                     BookId = 2,
                     AuthorId = 5,
                     AmountOfPages = 572,
                     BookName = "Man Of The Eternal",
                     Cost = 100,
                     GenreId = 2,
                     PriceToSell = 300,
                     PublishingId = 1,
                     PublishingYear = 2019
                },
                new Book
                {
                     BookId = 3,
                     AuthorId = 1,
                     AmountOfPages = 493,
                     BookName = "Witches Of The Ancients",
                     Cost = 699,
                     GenreId = 5,
                     PriceToSell = 1200,
                     PublishingId = 3,
                     PublishingYear = 2020
                },
                new Book
                {
                     BookId = 4,
                     AuthorId = 2,
                     AmountOfPages = 395,
                     BookName = "Girls Of Hell",
                     Cost = 1099,
                     GenreId = 1,
                     PriceToSell = 1698,
                     PublishingId = 1,
                     PublishingYear = 2017
                },
                new Book
                {
                     BookId = 5,
                     AuthorId = 6,
                     AmountOfPages = 739,
                     BookName = "Foes And Gangsters",
                     Cost = 399,
                     GenreId = 3,
                     PriceToSell = 490,
                     PublishingId = 3,
                     PublishingYear = 2005
                },
                new Book
                {
                     BookId = 6,
                     AuthorId = 1,
                     AmountOfPages = 728,
                     BookName = "Foes And Cats",
                     Cost = 305,
                     GenreId = 5,
                     PriceToSell = 604,
                     PublishingId = 2,
                     PublishingYear = 2021
                },
                new Book
                {
                     BookId = 7,
                     AuthorId = 2,
                     AmountOfPages = 253,
                     BookName = "Choice With Gold",
                     Cost = 302,
                     GenreId = 1,
                     PriceToSell = 492,
                     PublishingId = 1,
                     PublishingYear = 2016
                },
                new Book
                {
                     BookId = 8,
                     AuthorId = 4,
                     AmountOfPages = 525,
                     BookName = "Means Without Courage",
                     Cost = 820,
                     GenreId = 2,
                     PriceToSell = 972,
                     PublishingId = 3,
                     PublishingYear = 2023
                }
            });
        }

        public static void SeedClients(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Credential>().HasData(new Credential[]
            {
                new Credential
                {
                      ClientId = 1,
                      Login = "sullen",
                      Password = "KBSkNeKu"
                },
                new Credential
                {
                      ClientId = 2,
                      Login = "real",
                      Password = "GLmATFfF"
                },
                new Credential
                {
                      ClientId = 3,
                      Login = "immediate",
                      Password = "g9H4r6pC"
                },
                new Credential
                {
                      ClientId = 4,
                      Login = "blackbird",
                      Password = "eaxH9cMk"
                },
                new Credential
                {
                      ClientId = 5,
                      Login = "grapefruit",
                      Password = "xvMhDaqK"
                },
                new Credential
                {
                      ClientId = 6,
                      Login = "trice",
                      Password = "Wh5XRHzu"
                },
                new Credential
                {
                      ClientId = 7,
                      Login = "edge",
                      Password = "xvMhDaqK"
                },
                new Credential
                {
                      ClientId = 8,
                      Login = "taco",
                      Password = ""
                },
                new Credential
                {
                      ClientId = 9,
                      Login = "bale",
                      Password = ""
                },
                new Credential
                {
                      ClientId = 10,
                      Login = "tacit",
                      Password = "BWGncz5f"
                }
            });
        }

        public static void SeedPromotions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Promotion>().HasData(new Promotion[]
            {
                new Promotion
                {
                     PromotionsId = 1,
                     Discount = 94, 
                     PromotionsName = "Chrome book shop"
                },
                new Promotion
                {
                     PromotionsId = 2,
                     Discount = 31,
                     PromotionsName = "Suburban book shop"
                },
                new Promotion
                {
                     PromotionsId = 3,
                     Discount = 75,
                     PromotionsName = "Viral book shop"
                },
                new Promotion
                {
                     PromotionsId = 4,
                     Discount = 294,
                     PromotionsName = "Wonderland book shop"
                },
                new Promotion
                {
                     PromotionsId = 5,
                     Discount = 12,
                     PromotionsName = "Mate book shop"
                }
            });
        }

        public static void SeedSales(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sale>().HasData(new Sale[]
            {
                new Sale
                {
                      SaleId = 1,
                      Amount = 2,
                      BookId = 2,
                      CLientId = 5,
                      Date = new DateTime(11/22/2023),
                      Price = 272
                },
                new Sale
                {
                      SaleId = 2,
                      Amount = 8,
                      BookId = 4,
                      CLientId = 10,
                      Date = new DateTime(01/03/2021),
                      Price = 382
                },
                new Sale
                {
                      SaleId = 3,
                      Amount = 10,
                      BookId = 6,
                      CLientId = 2,
                      Date = new DateTime(04/17/2022),
                      Price = 135
                },
                new Sale
                {
                      SaleId = 4,
                      Amount = 3,
                      BookId = 8,
                      CLientId = 4,
                      Date = new DateTime(05/12/2019),
                      Price = 826
                },
                new Sale
                {
                      SaleId = 5,
                      Amount = 6,
                      BookId = 1,
                      CLientId = 6,
                      Date = new DateTime(10/30/2012),
                      Price = 829
                },
                new Sale
                {
                      SaleId = 6,
                      Amount = 4,
                      BookId = 3,
                      CLientId = 8,
                      Date = new DateTime(03/24/2023),
                      Price = 273
                },
                new Sale
                {
                      SaleId = 7,
                      Amount = 7,
                      BookId = 5,
                      CLientId = 1,
                      Date = new DateTime(12/19/2023),
                      Price = 627
                },
                new Sale
                {
                      SaleId = 8,
                      Amount = 1,
                      BookId = 7,
                      CLientId = 3,
                      Date = new DateTime(08/09/2020),
                      Price = 274
                }
            });
        }

        public static void SeedTrays(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tray>().HasData(new Tray[]
            {
                new Tray
                {
                     TrayId = 1,
                     BookId = 2, 
                     Amount = 15,
                     ClientId = 9
                },
                new Tray
                {
                     TrayId = 2,
                     BookId = 7,
                     Amount = 3,
                     ClientId = 2
                },
                new Tray
                {
                     TrayId = 3,
                     BookId = 4,
                     Amount = 1,
                     ClientId = 4
                },
                new Tray
                {
                     TrayId = 4,
                     BookId = 1,
                     Amount = 12,
                     ClientId = 6
                },
                new Tray
                {
                     TrayId = 5,
                     BookId = 6,
                     Amount = 7,
                     ClientId = 5
                },
            });
        }
    }
}