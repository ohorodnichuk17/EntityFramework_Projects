using ExamEntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamEntityFramework
{
    public class BookStore
    {
        public void AddBook()
        {
            Console.Write("Enter book name: ");
            string name = Console.ReadLine();

            Console.Write("Enter author id: ");
            int author = int.Parse(Console.ReadLine());

            Console.Write("Enter publishing id: ");
            int publishing = int.Parse(Console.ReadLine());

            Console.Write("Enter amount of pages: ");
            int amountOfPages = int.Parse(Console.ReadLine());

            Console.Write("Enter genre id: ");
            int genre = int.Parse(Console.ReadLine());

            Console.Write("Enter cost: ");
            double cost = double.Parse(Console.ReadLine());

            Console.Write("Enter price to sell: ");
            double priceToSell = double.Parse(Console.ReadLine());

            Console.Write("Enter publishing year: ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("Invalid year, please try again.");
                Console.Write("Enter publishing year: ");
            }

            Book book = new Book
            {
                BookName = name,
                AuthorId = author,
                PublishingId = publishing,
                AmountOfPages = amountOfPages,
                GenreId = genre,
                PublishingYear = year,
                Cost = cost,
                PriceToSell = priceToSell
            };

            using (var context = new BooksDbContext())
            {
                context.Books.Add(book);
                context.SaveChanges();
            }

            Console.WriteLine("Book added successfully.");
        }


        public void UpdateBook()
        {
            Console.Write("Enter book id to update: ");
            int id = int.Parse(Console.ReadLine());

            using (var context = new BooksDbContext())
            {
                var book = context.Books.Find(id);

                if (book == null)
                {
                    Console.WriteLine("Book not found.");
                    return;
                }

                Console.Write("Enter new book name (leave empty to keep current value): ");
                string name = Console.ReadLine();

                if (!string.IsNullOrEmpty(name))
                {
                    book.BookName = name;
                }

                Console.Write("Enter new author id (leave empty to keep current value): ");
                string author = Console.ReadLine();

                if (!string.IsNullOrEmpty(author))
                {
                    book.AuthorId = int.Parse(author);
                }

                Console.Write("Enter new publishing id (leave empty to keep current value): ");
                string publishing = Console.ReadLine();

                if (!string.IsNullOrEmpty(publishing))
                {
                    book.PublishingId = int.Parse(publishing);
                }

                Console.Write("Enter new amount of pages (leave empty to keep current value): ");
                string amountOfPages = Console.ReadLine();

                if (!string.IsNullOrEmpty(amountOfPages))
                {
                    book.AmountOfPages = int.Parse(amountOfPages);
                }

                Console.Write("Enter new genre id (leave empty to keep current value): ");
                string genre = Console.ReadLine();

                if (!string.IsNullOrEmpty(genre))
                {
                    book.GenreId = int.Parse(genre);
                }

                Console.Write("Enter new cost (leave empty to keep current value): ");
                string cost = Console.ReadLine();

                if (!string.IsNullOrEmpty(cost))
                {
                    book.Cost = double.Parse(cost);
                }

                Console.Write("Enter new price to sell (leave empty to keep current value): ");
                string priceToSell = Console.ReadLine();

                if (!string.IsNullOrEmpty(priceToSell))
                {
                    book.PriceToSell = double.Parse(priceToSell);
                }

                Console.Write("Enter new publishing year (leave empty to keep current value): ");
                string year = Console.ReadLine();

                if (!string.IsNullOrEmpty(year))
                {
                    int publishingYear;

                    while (!int.TryParse(year, out publishingYear))
                    {
                        Console.WriteLine("Invalid year, please try again.");
                        Console.Write("Enter new publishing year: ");
                        year = Console.ReadLine();
                    }

                    book.PublishingYear = publishingYear;
                }

                context.SaveChanges();
            }

            Console.WriteLine("Book updated successfully.");
        }


        public void SellBook()
        {
            Console.Write("Enter book id: ");
            int bookId;
            while (!int.TryParse(Console.ReadLine(), out bookId))
            {
                Console.WriteLine("Invalid book id, please try again.");
                Console.Write("Enter book id: ");
            }

            using (var context = new BooksDbContext())
            {
                var book = context.Books.FirstOrDefault(b => b.BookId == bookId);
                if (book != null)
                {
                    Console.WriteLine("Enter amount of pages to sell: ");
                    int amountToSell;
                    while (!int.TryParse(Console.ReadLine(), out amountToSell))
                    {
                        Console.WriteLine("Invalid amount, please try again.");
                        Console.WriteLine("Enter amount of pages to sell: ");
                    }
                    if (amountToSell > book.AmountOfPages)
                    {
                        Console.WriteLine("Amount exceeds the available amount of pages.");
                    }
                    else
                    {
                        book.AmountOfPages -= amountToSell;
                        context.SaveChanges();
                        Console.WriteLine($"Sold {amountToSell} pages of book {book.BookName} successfully.");
                    }
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
            }
        }


        public void DiscountBooks()
        {
            Console.Write("Enter genre id: ");
            int genreId;
            while (!int.TryParse(Console.ReadLine(), out genreId))
            {
                Console.WriteLine("Invalid genre id, please try again.");
                Console.Write("Enter genre id: ");
            }

            Console.Write("Enter discount percentage (0-100): ");
            double discountPercentage;
            while (!double.TryParse(Console.ReadLine(), out discountPercentage) || discountPercentage < 0 || discountPercentage > 100)
            {
                Console.WriteLine("Invalid discount percentage, please try again.");
                Console.Write("Enter discount percentage (0-100): ");
            }
            discountPercentage /= 100;

            using (var context = new BooksDbContext())
            {
                var books = context.Books.Where(b => b.GenreId == genreId);
                foreach (var book in books)
                {
                    book.PriceToSell *= (1 - discountPercentage);
                }
                context.SaveChanges();

                Console.WriteLine($"Discounted {books.Count()} books of genre {genreId} by {discountPercentage:P} successfully.");
            }
        }


        public void ShowBooks()
        {
            using (var context = new BooksDbContext())
            {
                var book = context.Books.ToList();
                foreach (var books in book)
                {
                    Console.WriteLine($"Id: {books.BookId}\n Name: {books.BookName}\n " +
                        $"AuthorId: {books.AuthorId}\n PublishingId: {books.PublishingId}\n " +
                        $"Amount of pages: {books.AmountOfPages}\n GenreId: {books.GenreId}\n" +
                        $"Publishing year: {books.PublishingYear}\n Cost: {books.Cost}\n Price to sell: {books.PriceToSell}");
                }
            }
        }

        public void ShowAuthors()
        {
            using (var context = new BooksDbContext())
            {
                var author = context.Authors.ToList();
                foreach (var a in author)
                {
                    Console.WriteLine($"Id: {a.AuthorId}\n Name: {a.Name}\n Surname: {a.Surname}");
                }
            }
        }


        public void ShowCredentials()
        {
            using (var context = new BooksDbContext())
            {
                var credential = context.Clients.ToList();
                foreach (var c in credential)
                {
                    Console.WriteLine($"Id: {c.ClientId}\n Login: {c.Login}\n Password: {c.Password}");
                }
            }
        }

        public void ShowGenres()
        {
            using (var context = new BooksDbContext())
            {
                var genre = context.Genres.ToList();
                foreach (var g in genre)
                {
                    Console.WriteLine($"Id: {g.GenreId}\n Name: {g.GenreName}");
                }
            }
        }

        public void ShowPromotions()
        {
            using (var context = new BooksDbContext())
            {
                var promotion = context.Promotions.ToList();
                foreach (var p in promotion)
                {
                    Console.WriteLine($"Id: {p.PromotionsId}\n Name: {p.PromotionsName}\n Discount: {p.Discount}");
                }
            }
        }

        public void ShowPublishings()
        {
            using (var context = new BooksDbContext())
            {
                var publishing = context.Publishings.ToList();
                foreach (var p in publishing)
                {
                    Console.WriteLine($"Id: {p.PublishingId}\n Name: {p.PublishingName}");
                }
            }
        }

        public void ShowSales()
        {
            using (var context = new BooksDbContext())
            {
                var sale = context.Sales.ToList();
                foreach (var s in sale)
                {
                    Console.WriteLine($"Id: {s.SaleId}\n Client id: {s.CLientId}\n Book id: {s.BookId}\n " +
                        $"Amount: {s.Amount}\n Price: {s.Price}\n Date: {s.Date}");
                }
            }
        }

        public void ShowTrays()
        {
            using (var context = new BooksDbContext())
            {
                var tray = context.Trays.ToList();
                foreach (var t in tray)
                {
                    Console.WriteLine($"Id: {t.TrayId}\n Client id: {t.ClientId}\n" +
                        $" Book id: {t.BookId}\n Amount: {t.Amount}");
                }
            }
        }
    }
}
