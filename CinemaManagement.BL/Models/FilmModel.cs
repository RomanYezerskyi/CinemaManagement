using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CinemaManagement.BL.Models
{
    public class FilmModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Actors { get; set; }
        public string Producers { get; set; }
        public string Description { get; set; }
        public string LinkTrailer { get; set; }
        public DateTime ReleaseDate { get; set; }
        [AllowNull]
        public ICollection<IFormFile> ImagesData { get; set; }
        public ICollection<SessionModel> Sessions { get; set; }
        public ICollection<FilmImagesModel> Images { get; set; }
    }
}
