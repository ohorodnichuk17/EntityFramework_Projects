using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzEntityFramework1.Entities
{
    public class Playlist
    {
        public int PlaylistId { get; set; }
        public string Name { get; set; }
        public ICollection<Track> Tracks { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
