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
    public class SessionController : ControllerBase
    {
        private readonly ISessionService _sessionService;
        public SessionController(ISessionService sessionService)
        {
            _sessionService = sessionService;
        }
        [HttpGet]
        public async Task<IEnumerable<SessionModel>> GetAllSessions()
        {
            try
            {
                return await _sessionService.GetAllAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }
        [HttpGet("{id}")]
        public async Task<SessionModel> GetSessionById(int id)
        {
            try
            {
                return await _sessionService.GetByIdAsync(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateSessions([FromBody] SessionModel model)
        {
            try
            {
                if (model == null) return BadRequest();
                var res = await _sessionService.AddAsync(model);
                if (res) return new JsonResult("Added Successfully");
                return new JsonResult("Fail");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSession([FromBody] SessionModel model)
        {
            try
            {
                if (model == null) return BadRequest();
                var res = await _sessionService.UpdateAsync(model);
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
                var res = await _sessionService.DeleteByIdAsync(id);
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
