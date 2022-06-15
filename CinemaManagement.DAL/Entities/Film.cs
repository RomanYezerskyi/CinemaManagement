using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DAL.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Actors { get; set; }
        public string Producers { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string LinkTrailer { get; set; }
        public ICollection<FilmImage> Images { get; set; }
        public ICollection<Session> Sessions { get; set; }
    }
}
