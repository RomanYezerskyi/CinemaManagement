using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DAL.Entities
{
    public class FilmImage
    {
        public int Id { get; set; }
        public string ImageData { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; }
    }
}
