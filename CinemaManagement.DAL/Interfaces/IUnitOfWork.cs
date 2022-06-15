using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL.Entities;

namespace CinemaManagement.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepositoryAsync<User> Users { get; }
        IRepositoryAsync<Film> Films { get; }
        IRepositoryAsync<Hall> Halls { get; }
        IRepositoryAsync<Seat> Seats { get; }
        IRepositoryAsync<Session> Sessions { get; }
        IRepositoryAsync<Reservation> Reservations { get; }
        IRepositoryAsync<FilmImage> FilmImages { get; }
        IRepositoryAsync<Achievement> Achievements { get; }
        IRepositoryAsync<BookedSeat> BookedSeats { get; }
        Task<bool> SaveAsync();
    }
}
