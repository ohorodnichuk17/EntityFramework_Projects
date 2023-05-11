using DzEntityFramework1.Entities;
using System;
using System.Linq;

namespace DzEntityFramework1
{
    internal class Program
    {
        static void GetAllCountries()
        {
            using (var dbContext = new MusicDbContext())
            {
                var countries = dbContext.Countries.ToList();
                Console.WriteLine("Countries:");
                foreach (var country in countries)
                {
                    Console.WriteLine($"{country.CountryId} - {country.Name}");
                }
            }
        }

        static void GetAllArtists()
        {
            using (var dbContext = new MusicDbContext())
            {
                var artists = dbContext.Artists.ToList();
                Console.WriteLine("Artists:");
                foreach (var artist in artists)
                {
                    Console.WriteLine($"{artist.ArtistId} - {artist.Name} {artist.Surname} - {artist.Country}");
                }
            }
        }

        static void GetAllGenres()
        {
            using (var dbContext = new MusicDbContext())
            {
                var genres = dbContext.Genres.ToList();
                Console.WriteLine("Genres: ");
                foreach (var genre in genres)
                {
                    Console.WriteLine($"{genre.GenreId} - {genre.Name}");
                }
            }
        }

        static void GetAllAlbums()
        {
            using (var dbContext = new MusicDbContext())
            {
                var albums = dbContext.Albums.ToList();
                Console.WriteLine("Albums: ");
                foreach (var album in albums)
                {
                    Console.WriteLine($"{album.AlbumId} - {album.Name} - {album.Artist} - {album.Year} - {album.Genre}");
                }
            }
        }

        static void GetAllTracks()
        {
            using (var dbContext = new MusicDbContext())
            {
                var tracks = dbContext.Tracks.ToList();
                Console.WriteLine("Tracks: ");
                foreach (var track in tracks)
                {
                    Console.WriteLine($"{track.TrackId} - {track.Album} - {track.Duration}");
                }
            }
        }

        static void GetAllCategories()
        {
            using (var dbContext = new MusicDbContext())
            {
                var categories = dbContext.Categories.ToList();
                Console.WriteLine("Categories: ");
                foreach (var category in categories)
                {
                    Console.WriteLine($"{category.CategoryId} - {category.Name}");
                }
            }
        }

        static void GetAllPlaylists()
        {
            using (var dbContext = new MusicDbContext())
            {
                var playlists = dbContext.Playlists.ToList();
                Console.WriteLine("Playlists: ");
                foreach (var playlist in playlists)
                {
                    Console.WriteLine($"{playlist.PlaylistId} - {playlist.Name} - {playlist.Category} - {playlist.Tracks}");
                }
            }
        }

        static void ShowTracks(int albumId)
        {
            using (var dbContext = new MusicDbContext())
            {
                var albumAverageAuditions = dbContext.Tracks
                    .Where(t => t.AlbumId == albumId)
                    .Average(t => t.Auditions);

                var tracks = dbContext.Tracks
                    .Where(t => t.AlbumId == albumId && t.Auditions > albumAverageAuditions)
                    .ToList();
                Console.WriteLine($"Треки з альбому {albumId}, кількість прослуховувань яких більша за середнє значення {albumAverageAuditions}:");
                foreach (var track in tracks)
                {
                    Console.WriteLine($"- (ID: {track.TrackId}, Кількість прослуховувань: {track.Auditions})");
                }
            }
        }

        static void TopTracks(int artistId)
        {
            Console.WriteLine("Top 3 tracks and albums: ");
            using (var dbContext = new MusicDbContext())
            {
                var topTracks = dbContext.Tracks
                .Where(t => t.ArtistId == artistId)
                .OrderByDescending(t => t.Rating)
                .Take(3)
                .ToList();

                var topAlbums = topTracks
                   .GroupBy(t => t.AlbumId)
                   .Select(g => new { AlbumId = g.Key, Rating = g.Max(t => t.Rating) })
                   .OrderByDescending(a => a.Rating)
                   .Take(3)
                   .ToList();

                foreach (var album in topAlbums)
                {
                    var albumTitle = dbContext.Albums.FirstOrDefault(a => a.AlbumId == album.AlbumId)?.Genre;
                    Console.WriteLine($"- Rating: {album.Rating}");

                    var albumTracks = topTracks.Where(t => t.AlbumId == album.AlbumId).ToList();
                    foreach (var track in albumTracks)
                    {
                        Console.WriteLine($"- Rating: {track.Rating}");
                    }
                }

            }
        }

        static void Main(string[] args)
        {
            MusicDbContext context = new MusicDbContext();

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
                Console.WriteLine("[2] - Display all information about artists");
                Console.WriteLine("[3] - Display all information about genres");
                Console.WriteLine("[4] - Display all information about albums");
                Console.WriteLine("[5] - Display all information about tracks");
                Console.WriteLine("[6] - Display all information about categories");
                Console.WriteLine("[7] - Display all information about playlists");
                Console.WriteLine("[8] - Display the tracks of a specific album with the highest number of listens");
                Console.WriteLine("[9] - Display the TOP-3 tracks and albums of a certain artist by rating");
                Console.WriteLine("[0] - Exit");
                num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1: GetAllCountries(); break;
                    case 2: GetAllArtists(); break;
                    case 3: GetAllGenres(); break;
                    case 4: GetAllAlbums(); break;
                    case 5: GetAllTracks(); break;
                    case 6: GetAllCategories(); break;
                    case 7: GetAllPlaylists(); break;
                    case 8: ShowTracks(4); break;
                    case 9: TopTracks(2); break;
                    case 0: Environment.Exit(0); break;
                    default:
                        Console.WriteLine("Error!!!");
                        break;
                }
            } while (num != 0);

        }
    }
}
