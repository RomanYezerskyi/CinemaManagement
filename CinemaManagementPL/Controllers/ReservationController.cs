using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CinemaManagement.BL.Interfaces;
using CinemaManagement.BL.Models;

namespace CinemaManagementPL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet]
        public async Task<IEnumerable<ReservationModel>> GetAllReservation()
        {
            try
            {
                return await _reservationService.GetAllAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }
        [HttpGet("{userId}")]
        public async Task<IEnumerable<ReservationModel>> GetUserReservations(string userId)
        {
            try
            {
                return await _reservationService.GetUserReservations(userId);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpGet("{id}")]
        public async Task<ReservationModel> GetReservationById(int id)
        {
            try
            {
                return await _reservationService.GetByIdAsync(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateReservation([FromBody] ReservationModel model)
        {
            try
            {
                if (model == null) return BadRequest();
                var res = await _reservationService.AddModelAsync(model);
                if (res != null) return new JsonResult(res);
                return new JsonResult("Fail");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateReservation([FromBody] ReservationModel model)
        {
            try
            {
                if (model == null) return BadRequest();
                var res = await _reservationService.UpdateAsync(model);
                if (res) return new JsonResult("Added Successfully");
                return new JsonResult("Fail");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSessionById(int id)
        {
            try
            {
                var res = await _reservationService.DeleteByIdAsync(id);
                if (res) return new JsonResult("Deleted Successfully");
                return new JsonResult("Fail");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
