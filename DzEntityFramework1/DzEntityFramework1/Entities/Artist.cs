using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzEntityFramework1.Entities
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Country Country { get; set; }
    }
}
