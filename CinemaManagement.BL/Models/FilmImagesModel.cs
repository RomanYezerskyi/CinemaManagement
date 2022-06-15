using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BL.Models
{
    public class FilmImagesModel
    {
        public int Id { get; set; }
        public string ImageData { get; set; }
        public int FilmId { get; set; }
        public FilmModel Film { get; set; }
    }
}
