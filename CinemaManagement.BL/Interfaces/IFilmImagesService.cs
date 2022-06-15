using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.BL.Models;
using Microsoft.AspNetCore.Http;

namespace CinemaManagement.BL.Interfaces
{
    public interface IFilmImagesService
    {
        Task<FilmImagesModel> GetFilmImage(int imageId);
        Task<IEnumerable<FilmImagesModel>> GetFilmImages(int filmId);
        Task<bool> AddImagesToFilm(ICollection<IFormFile> formFiles, int filmId);
        Task<bool> DeleteImage(int imageId);
    }
}
