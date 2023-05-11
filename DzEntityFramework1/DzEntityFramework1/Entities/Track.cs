using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzEntityFramework1.Entities
{
    public class Track
    {
        public int TrackId { get; set; }
        public int ArtistId { get; set; }
        public Album Album { get; set; }
        public TimeSpan Duration { get; set; }
        public int AlbumId { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
        public int Rating { get; set; }
        public double Auditions { get; set; }
        public string Text { get; set; }
    }
}
