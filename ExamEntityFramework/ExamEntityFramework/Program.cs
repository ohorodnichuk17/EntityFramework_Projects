using ExamEntityFramework.Entities;
using System;
using System.Linq;

namespace ExamEntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BooksDbContext context = new BooksDbContext();

            if (context.Database.CanConnect())
            {
                Console.WriteLine("Connection successful");
            }
            else
            {
                Console.WriteLine("Connection failed");
            }

            BookStore bookStore = new BookStore();

            int num = 0;
            do
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("---------------------Book Store-------------------------");
                Console.WriteLine("[1] - Add new book");
                Console.WriteLine("[2] - Update book");
                Console.WriteLine("[3] - Sell book");
                Console.WriteLine("[4] - Discount book");
                Console.WriteLine("[5] - Display information about all books");
                Console.WriteLine("[6] - Display information about all authors");
                Console.WriteLine("[7] - Display information about all credentials");
                Console.WriteLine("[8] - Display information about all genres");
                Console.WriteLine("[9] - Display information about all promotions");
                Console.WriteLine("[10] - Display information about all publishings");
                Console.WriteLine("[11] - Display information about all sales");
                Console.WriteLine("[12] - Display information about all trays");
                Console.WriteLine("[0] - Exit");
                Console.WriteLine("--------------------------------------------------------");
                num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1: bookStore.AddBook(); break;
                    case 2: bookStore.UpdateBook(); break;
                    case 3: bookStore.SellBook(); break;
                    case 4: bookStore.DiscountBooks(); break;
                    case 5: bookStore.ShowBooks(); break;
                    case 6: bookStore.ShowAuthors(); break;
                    case 7: bookStore.ShowCredentials(); break;
                    case 8: bookStore.ShowGenres(); break;
                    case 9: bookStore.ShowPromotions(); break;
                    case 10: bookStore.ShowPublishings(); break;
                    case 11: bookStore.ShowSales(); break;
                    case 12: bookStore.ShowTrays(); break;
                    case 0: Environment.Exit(0); break;
                    default: Console.WriteLine("Error!!!"); break;
                }

            } while (num != 0);
        }
    }
}
