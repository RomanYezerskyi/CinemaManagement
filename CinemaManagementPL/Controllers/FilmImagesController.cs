using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaManagement.BL.Interfaces;
using CinemaManagement.BL.Models;


namespace CinemaManagementPL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmImagesController : ControllerBase
    {
        private readonly IFilmImagesService _filmImagesService;
        public FilmImagesController(IFilmImagesService filmImagesService)
        {
            _filmImagesService = filmImagesService;
        }

        [HttpGet("{imageId}")]
        public async Task<FilmImagesModel> GetFilmImage(int imageId)
        {
            try
            {
                return await _filmImagesService.GetFilmImage(imageId);

            }
            catch (Exception e)
            {
                return null;
            }
        }
        [HttpGet("{filmId}")]
        public async Task<IEnumerable<FilmImagesModel>> GetAllFilmImages(int filmId)
        {
            try
            {
                return await _filmImagesService.GetFilmImages(filmId);

            }
            catch (Exception e)
            {
                return null;
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddImagesToFilm(ICollection<IFormFile> images, int filmId)
        {
            try
            {
                var res = await _filmImagesService.AddImagesToFilm(images, filmId);
                if (res) return new JsonResult("Added Successfully");
                return new JsonResult("Fail");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete("{imageId}")]
        public async Task<IActionResult> DeleteFilmImage(int imageId)
        {
            try
            {
                var res = await _filmImagesService.DeleteImage(imageId);
                if (res) return new JsonResult("Deleted Successfully");
                return new JsonResult("Fail");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
