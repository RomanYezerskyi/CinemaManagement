using System;
using System.Collections.Generic;
using System.Linq;
using CinemaManagement.BL.Email;
using CinemaManagement.BL.Interfaces;
using CinemaManagement.BL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaManagementPL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        public IEmailSender _emailSender;
        private readonly AuthorizationService _authService;
        private readonly IReservationService _reservationService;
        public EmailController(IEmailSender sender, AuthorizationService authService, IReservationService reservation)
        {
            _emailSender = sender;
            _authService = authService;
            _reservationService = reservation;

        }
        [HttpGet]
        public bool GetEmail(int reservationId)
        {
            var message = new Message(new string[] { "" }, "", "");
            _emailSender.SendEmail(message);
            return true;
        }
    }
}
