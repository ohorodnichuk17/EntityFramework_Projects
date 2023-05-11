using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzEntityFramework1.Entities
{
    public class Album
    {
        public int AlbumId { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }
        public ICollection<Artist> Artist { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
    }
}
