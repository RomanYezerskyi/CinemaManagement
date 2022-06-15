using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.BL.Models;
using CinemaManagement.DAL.Entities;

namespace CinemaManagement.BL.Interfaces
{
    public interface IReservationService : ICrud<ReservationModel>
    {
        public Task<IEnumerable<ReservationModel>> GetUserReservations(string userId);
        new Task<Reservation> AddModelAsync(ReservationModel model);
    }
}
