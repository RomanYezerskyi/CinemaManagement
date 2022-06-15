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
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly IFilmService _filmService;
        public FilmController(IFilmService filmService)
        {
            _filmService = filmService;
        }

        [HttpGet]
        public async Task<IEnumerable<FilmModel>> GetAllFilms()
        {
            try
            {
                return await _filmService.GetAllAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }
        [HttpGet("{id}")]
        public async Task<FilmModel> GetFilmById(int id)
        {
            try
            {
                return await _filmService.GetByIdAsync(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateFilm([FromBody] FilmModel filmModel)
        {
            try
            {
                if (filmModel == null)
                    return BadRequest();
                var res = await _filmService.AddAsync(filmModel);
                if (res) return new JsonResult("Added Successfully");
                return new JsonResult("Fail");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFilm([FromBody] FilmModel model)
        {
            if (model == null)
                return BadRequest();
            try
            {
                var res = await _filmService.UpdateAsync(model);
                if (res) return new JsonResult("Updated Successfully");
                return new JsonResult("Fail");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFilm(int id)
        {
            try
            {
                var res = await _filmService.DeleteByIdAsync(id);
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
