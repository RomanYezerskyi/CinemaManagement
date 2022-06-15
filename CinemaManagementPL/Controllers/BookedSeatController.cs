using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CinemaManagement.BL.Interfaces;
using CinemaManagement.BL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CinemaManagementPL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookedSeatController : ControllerBase
    {
        private readonly IBookedSeatService _bookedSeatService;
        public BookedSeatController(IBookedSeatService bookedSeatService)
        {
            _bookedSeatService = bookedSeatService;
        }
        [HttpGet]
        public async Task<IEnumerable<BookedSeatModel>> GetAllBookedSeats()
        {
            try
            {
                return await _bookedSeatService.GetAllAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }
        [HttpGet("{id}")]
        public async Task<BookedSeatModel> GetBookedSeatById(int id)
        {
            try
            {
                return await _bookedSeatService.GetByIdAsync(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateBookedSeat([FromBody] BookedSeatModel model)
        {
            try
            {
                if (model == null) return BadRequest();
                var res = await _bookedSeatService.AddAsync(model);
                if (res) return new JsonResult("Added Successfully");
                return new JsonResult("Fail");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost("/range")]
        public async Task<IActionResult> CreateRangeBookedSeats([FromBody] IEnumerable<BookedSeatModel> model)
        {
            try
            {
                if (model == null) return BadRequest();
                var res = await _bookedSeatService.AddRangeAsync(model);
                if (res) return new JsonResult("Added Successfully");
                return new JsonResult("Fail");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBookedSeat([FromBody] BookedSeatModel model)
        {
            try
            {
                if (model == null) return BadRequest();
                var res = await _bookedSeatService.UpdateAsync(model);
                if (res) return new JsonResult("Added Successfully");
                return new JsonResult("Fail");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookedSeatById(int id)
        {
            try
            {
                var res = await _bookedSeatService.DeleteByIdAsync(id);
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
