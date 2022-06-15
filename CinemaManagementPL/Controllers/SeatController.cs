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
    public class SeatController : ControllerBase
    {
        private readonly ISeatService _seatService;
        public SeatController(ISeatService seatService)
        {
            _seatService = seatService;
        }
        [HttpGet]
        public async Task<IEnumerable<SeatModel>> GetAllSeats()
        {
            try
            {
                return await _seatService.GetAllAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }
        [HttpGet("{id}")]
        public async Task<SeatModel> GetSeatById(int id)
        {
            try
            {
                return await _seatService.GetByIdAsync(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateSeat([FromBody] SeatModel model)
        {
            try
            {
                if (model == null) return BadRequest();
                var res = await _seatService.AddAsync(model);
                if (res) return new JsonResult("Added Successfully");
                return new JsonResult("Fail");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost("/range")]
        public async Task<IActionResult> CreateRangeSeats([FromBody] IEnumerable<SeatModel> model)
        {
            try
            {
                if (model == null) return BadRequest();
                var res = await _seatService.AddRangeAsync(model);
                if (res) return new JsonResult("Added Successfully");
                return new JsonResult("Fail");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSeat([FromBody] SeatModel model)
        {
            try
            {
                if (model == null) return BadRequest();
                var res = await _seatService.UpdateAsync(model);
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
        public async Task<IActionResult> DeleteSeatById(int id)
        {
            try
            {
                var res = await _seatService.DeleteByIdAsync(id);
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
