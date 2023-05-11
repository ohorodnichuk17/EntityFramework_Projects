using ExamEntityFramework.Entities;
using ExamEntityFramework.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamEntityFramework
{
    public class BooksDbContext : DbContext
    {
        public BooksDbContext()
        {
            //this.Database.EnsureDeleted();
            //this.Database.EnsureCreated();
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Credential> Clients { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Publishing> Publishings { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Tray> Trays { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=JULIAOHORODNICH\SQLEXPRESS;
                                        Initial Catalog=ExamBookDb;
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

            modelBuilder.SeedAuthors();
            modelBuilder.SeedBooks();
            modelBuilder.SeedClients();
            modelBuilder.SeedGenres();
            modelBuilder.SeedPromotions();
            modelBuilder.SeedPublishings();
            modelBuilder.SeedSales();
            modelBuilder.SeedTrays();
        }

    }
}
