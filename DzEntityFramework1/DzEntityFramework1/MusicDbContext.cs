using DzEntityFramework1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzEntityFramework1
{
    internal class MusicDbContext : DbContext
    {
        //public MusicDbContext() : base()
        //{
        //    this.Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=JULIAOHORODNICH\SQLEXPRESS;
                                        Initial Catalog=DatabaseMusic2;
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

            modelBuilder.Entity<Country>().HasData(
                new Country { CountryId = 1, Name = "США" },
                new Country { CountryId = 2, Name = "PL" },
                new Country { CountryId = 3, Name = "UK" },
                new Country { CountryId = 4, Name = "BG" },
                new Country { CountryId = 5, Name = "UA" });

            modelBuilder.Entity<Artist>().HasData(
                new Artist { ArtistId = 1, Name = "Slim", Surname = "Shady", CountryId = 1 },
                new Artist { ArtistId = 2, Name = "Tion", Surname = "Wayne", CountryId = 3 },
                new Artist { ArtistId = 3, Name = "Lory", Surname = "Rywa", CountryId = 2 },
                new Artist { ArtistId = 4, Name = "Arturro", Surname = "Mass", CountryId = 5 },
                new Artist { ArtistId = 5, Name = "Mark", Surname = "Urso", CountryId = 4 });

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = 1, Name = "Rap" },
                new Genre { GenreId = 2, Name = "Pop" },
                new Genre { GenreId = 3, Name = "Rock" },
                new Genre { GenreId = 4, Name = "Juzz" },
                new Genre { GenreId = 5, Name = "Classic" });

            modelBuilder.Entity<Album>().HasData(
                new Album { AlbumId = 1, Name = "Kamikaze", Year = 2020, ArtistId = 2, GenreId = 1, Rating = 8 },
                new Album { AlbumId = 2, Name = "Body Language", Year = 2008, ArtistId = 5, GenreId = 5, Rating = 2 },
                new Album { AlbumId = 3, Name = "Oczy wizji", Year = 2022, ArtistId = 1, GenreId = 3, Rating = 9 },
                new Album { AlbumId = 4, Name = "Fun", Year = 2017, ArtistId = 3, GenreId = 4, Rating = 4 },
                new Album { AlbumId = 5, Name = "Black Market", Year = 2015, ArtistId = 4, GenreId = 2, Rating = 10 });

            modelBuilder.Entity<Track>().HasData(
                new Track {TrackId = 1, ArtistId = 3, Duration = new TimeSpan(0, 3, 42), AlbumId = 3, Rating = 10, Auditions = 12930, Text = "xxxxxxxxxxxxxxxxxx" },
                new Track {TrackId = 2, ArtistId = 1, Duration = new TimeSpan(0, 4, 10), AlbumId = 5, Rating = 5, Auditions = 9728, Text = "xxxxxxxxxxxxxxxxxx" },
                new Track {TrackId = 3, ArtistId = 5, Duration = new TimeSpan(0, 5, 23), AlbumId = 1, Rating = 1, Auditions =  1000000, Text = "xxxxxxxxxxxxxxxxxx" },
                new Track {TrackId = 4, ArtistId = 4, Duration = new TimeSpan(0, 2, 50), AlbumId = 4, Rating = 4, Auditions =  29402, Text = "xxxxxxxxxxxxxxxxxx" },
                new Track {TrackId = 5, ArtistId = 2, Duration = new TimeSpan(0, 3, 58), AlbumId = 2, Rating = 7, Auditions =  18209, Text = "xxxxxxxxxxxxxxxxxx" });

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Action" },
                new Category { CategoryId = 2, Name = "Comedy" },
                new Category { CategoryId = 3, Name = "Drama" },
                new Category { CategoryId = 4, Name = "Horror" },
                new Category { CategoryId = 5, Name = "Romance" });

            modelBuilder.Entity<Playlist>().HasData(
                    new Playlist { PlaylistId = 1, Name = "My Playlist 1", CategoryId = 1 },
                    new Playlist { PlaylistId = 2, Name = "My Playlist 2", CategoryId = 2 },
                    new Playlist { PlaylistId = 3, Name = "My Playlist 3", CategoryId = 3 },
                    new Playlist { PlaylistId = 4, Name = "My Playlist 4", CategoryId = 4 },
                    new Playlist { PlaylistId = 5, Name = "My Playlist 5", CategoryId = 5 });
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
